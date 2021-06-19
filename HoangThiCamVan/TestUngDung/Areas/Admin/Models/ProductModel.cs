using ModelEF.Model;
using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.Admin.Models
{
    public class ProductModel
    {
        [Key]
        public int ID { get; set; }     
       [Required]        
        public string Name { get; set; }
        [Required]
        public decimal UnitCost { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int ID_Category { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}