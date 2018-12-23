using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    

    public class DepartmentManager:Person
    {

        public FormatManager formatManager { get; set; }

        public int formatManagerId { get; set; }
        
    }
}