using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    public class Worker:Person
    {
        

        public Worker()
        {
            this.Markets = new HashSet<Market>();
            
        }

        [Required]
        [Display(Name = "Yaş")]
        public byte Age { get; set; }

        [Required]
        [Display(Name = "Nəqliyyat Vastəsi Nömrəsi")]
        public string VehicleNumber { get; set; }

        [Required]
        [Display(Name = "FİN Kod")]
        public string RTcode { get; set; }

        [Required]
        [Display(Name = "Yol Xərci")]
        public byte TravelExpenses { get; set; }

        public ICollection<Market> Markets { get; set; }

        
    }

    
}