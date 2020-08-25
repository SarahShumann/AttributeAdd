using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class attribute
    {
        [Key]
       // public int ID { get; set; }
        
        public string attribute_code { get; set; }
        
        public string description { get; set; }
        public string description_code { get; set; }
        public string attribute_type { get; set; }
        public string entity_type { get; set; }
        public string parent_attribute_code { get; set; }
        public string is_required { get; set; }
        public int sort_order { get; set; }
        public string regular_expression { get; set; }
        public string mask { get; set; }
        public int? is_active { get; set; }
        public int? created_by_ID { get; set; }
        public DateTime? created_date { get; set; }
        public int? updated_by_ID { get; set; }
        public DateTime? updated_date { get; set; }
        public string placeholder_code { get; set; }
        public int? min_width { get; set; }


      //  public ICollection<attribute_value> attribute_Values { get; set; }
    }

}
