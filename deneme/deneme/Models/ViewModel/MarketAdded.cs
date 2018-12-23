using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme.Models.ViewModel
{
    public class MarketAdded
    {
       

        public string Name { get; set; }

        public string Adress { get; set; }
        
        public string Manager { get; set; }
        
        public Type Type { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }

        public static explicit operator Market(MarketAdded marketAdded)
        {
            Market market = new Market()
            {
                Name = marketAdded.Name,
                Adress = marketAdded.Adress,
                Manager = marketAdded.Manager,
                Type = marketAdded.Type,
                Location = marketAdded.Location,
                CreateTime = marketAdded.CreateTime,
                Workers = marketAdded.Workers

            };

            return market;
        }

    }

    
}