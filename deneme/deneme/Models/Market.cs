using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme.Models
{
    public enum Type
    {
        Discount = 1,
        SuperMarket
    }

    public class Market
    {
        public Market()
        {
            this.Workers = new HashSet<Worker>();
        }

        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ad")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Uzunluğu 3 və 20 aralığında simvol daxil edin.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Adres")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Uzunluğu 3 və 40 aralığında simvol daxil edin.")]
        public string Adress { get; set; }

        [Required]
        [Display(Name = "Direktor")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Uzunluğu 3 və 20 aralığında simvol daxil edin.")]
        public string Manager { get; set; }

        [Required]
        [Display(Name = "Type")]
        public Type Type { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        [Required]
        [Display(Name = "Yaranma Tarixi")]
        public DateTime CreateTime { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }


    }
}