using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.AM
{
    public class Assasins
    {
        [Key]
        [Required]
        public int IdAssassins { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MinPrice { get; set; }
        [Required]
        public int MaxPrice { get; set; }
        [Required]
        public bool Work { get; set; }

    }
}