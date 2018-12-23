using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    public class FormatManager:Person
    {
        
       

        public RegionalManager regionalManager { get; set; }

        public int regionalManagerId { get; set; }


    }
}