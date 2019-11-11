using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarMatrix.Models
{
    public class Tug
    {
        [Key]
        public int TugId { get; set; }

        [Required]
        [Display(Name = "Tug Name")]
        public string TugName { get; set; }
    }
}
