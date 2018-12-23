using System.ComponentModel.DataAnnotations;

namespace deneme.Models
{
    public class RegionalManager:Person
    {
        
        

        public Market market { get; set; }

        public int marketId { get; set; }
    }
}