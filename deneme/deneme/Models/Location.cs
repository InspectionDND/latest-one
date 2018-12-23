using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Y-Koordinat")]
        public decimal Lat { get; set; }

        [Required]
        [Display(Name = "X-Koordinat")]
        public decimal Lon { get; set; }
    }
}