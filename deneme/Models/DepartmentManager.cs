using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    

    public class DepartmentManager:Person
    {

        public FormatManager FormatManager { get; set; }

        public int FormatManagerId { get; set; }
        
    }
}