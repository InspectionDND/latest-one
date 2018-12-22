using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    public enum Position
    {
        BranchManager = 1,
        FormatManager,
        RegionalManager,
        Worker

    }

    public abstract class Person
    {
      
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ad")]
        [StringLength(20, MinimumLength = 3,ErrorMessage = "Uzunluğu 3 və 20 aralığında simvol daxil edin.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Uzunluğu 3 və 20 aralığında simvol daxil edin.")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Ata Adı")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Uzunluğu 3 və 20 aralığında simvol daxil edin.")]
        public string FatherName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Cinsiyyət")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Telefon Nömrəsi")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Qeydiyyat Tarixi")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "Vəzifəsi")]
        public Position Position { get; set; }


        
    }
}