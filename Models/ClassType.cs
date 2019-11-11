using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarMatrix.Models
{
    public class ClassType
    {
        [Key]
        public int ClassTypeId { get; set; }

        [Required]
        [Display(Name = "Class")]
        public string ClassTypeName { get; set; }
    }
}
