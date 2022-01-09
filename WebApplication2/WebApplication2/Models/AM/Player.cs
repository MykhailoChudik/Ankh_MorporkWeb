using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.AM
{
    public class Player
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Gold { get; set; }
        [Required]
        public int Thieves { get; set; }
        [Required]
        public int Beer { get; set; }
    }
}