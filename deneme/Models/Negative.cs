using System.ComponentModel.DataAnnotations;

namespace deneme.Models
{
    public class Negative
    {
        public byte Id { get; set; }

        [Required]
        [Display(Name = "Neqativ hal")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Dəyərləndirmə")]
        public byte Point { get; set; }

        [Required]
        [Display(Name = "Şərhlər")]
        public string Comments { get; set; }

        public string PhotoPath { get; set; }

        public string AudioPath { get; set; }


    }
}