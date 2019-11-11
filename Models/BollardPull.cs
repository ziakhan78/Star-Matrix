using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarMatrix.Models
{
    public class BollardPull
    {
        [Key]
        public int BollardPullId { get; set; }

        [Required]
        [Display(Name = "Bollard Pull")]
        public string BollardPullName { get; set; }
    }
}
