using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class attributesController : ControllerBase
    {
        private readonly APIDBContext _context;

        public attributesController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/attributes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<attribute>>> Getattribute()
        {
            return await _context.attribute.ToListAsync();
        }

        // GET: api/attributes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<attribute>> Getattribute(string id)
        {
            var attribute = await _context.attribute.FindAsync(id);

            if (attribute == null)
            {
                return NotFound();
            }

            return attribute;
        }

        // PUT: api/attributes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putattribute(string id, attribute attribute)
        {
            if (id != attribute.attribute_code)
            {
                return BadRequest();
            }

            _context.Entry(attribute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!attributeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/attributes
        [HttpPost]
        public async Task<ActionResult<attribute>> Postattribute(attribute attribute)
        {
            _context.attribute.Add(attribute);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getattribute", new { id = attribute.attribute_code }, attribute);
        }

        // DELETE: api/attributes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<attribute>> Deleteattribute(string id)
        {
            var attribute = await _context.attribute.FindAsync(id);
            if (attribute == null)
            {
                return NotFound();
            }

            _context.attribute.Remove(attribute);
            await _context.SaveChangesAsync();

            return attribute;
        }

        private bool attributeExists(string id)
        {
            return _context.attribute.Any(e => e.attribute_code == id);
        }
    }
}
