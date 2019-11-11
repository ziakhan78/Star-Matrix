using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarMatrix.Models
{
    public class EngineHP
    {
        [Key]
        public int EngineHPId { get; set; }

        [Required]
        [Display(Name = "Engine HP")]
        public string EngineHPName { get; set; }
    }
}
