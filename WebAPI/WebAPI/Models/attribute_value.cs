using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class attribute_value
    {
        [Key]
      //  public int ID { get; set; }
        
        public string attribute_value_code { get; set; }

        public string attribute_code { get; set; }
        
        public string description { get; set; }
        public string description_code { get; set; }
        public string parent_attribute_value_code { get; set; }
        
        public string is_active { get; set; }
        public int created_by_ID { get; set; }
        public DateTime created_date { get; set; }
        public int updated_by_ID { get; set; }
        public DateTime updated_date { get; set; }

        //[ForeignKey("attribute_code")]
        //public attribute attribute_code2 { get; set; }

        //public virtual ICollection<attribute> Attributes { get; set; }


    }
}
