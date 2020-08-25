using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class attribute_valueController : ControllerBase
    {
        private readonly APIDBContext _context;

        public attribute_valueController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/attribute_value
        [HttpGet]
        public async Task<ActionResult<IEnumerable<attribute_value>>> Getattribute_value()
        {
            return await _context.attribute_value.ToListAsync();
        }

        // GET: api/attribute_value/5
        [HttpGet("{id}")]
        public async Task<ActionResult<attribute_value>> Getattribute_value(string id)
        {
            var attribute_value = await _context.attribute_value.FindAsync(id);

            if (attribute_value == null)
            {
                return NotFound();
            }

            return attribute_value;
        }

        // PUT: api/attribute_value/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putattribute_value(string id, attribute_value attribute_value)
        {
            if (id != attribute_value.attribute_value_code)
            {
                return BadRequest();
            }

            _context.Entry(attribute_value).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!attribute_valueExists(id))
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

        // POST: api/attribute_value
        [HttpPost]
        public async Task<ActionResult<attribute_value>> Postattribute_value(attribute_value attribute_value)
        {
            _context.attribute_value.Add(attribute_value);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getattribute_value", new { id = attribute_value.attribute_value_code }, attribute_value);
        }

        // DELETE: api/attribute_value/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<attribute_value>> Deleteattribute_value(string id)
        {
            var attribute_value = await _context.attribute_value.FindAsync(id);
            if (attribute_value == null)
            {
                return NotFound();
            }

            _context.attribute_value.Remove(attribute_value);
            await _context.SaveChangesAsync();

            return attribute_value;
        }

        private bool attribute_valueExists(string id)
        {
            return _context.attribute_value.Any(e => e.attribute_value_code == id);
        }
    }
}
