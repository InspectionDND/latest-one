using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme.Models.ViewModel
{
    public class DepartmentMAdded
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime StartTime { get; set; }

        public byte Age { get; set; }

        public string Gender { get; set; }

        public Position Position { get; set; }

        public FormatManager formatManager { get; set; }

        public static explicit operator DepartmentManager(DepartmentMAdded departmentMAdded)
        {
            DepartmentManager departmentManager = new DepartmentManager()
            {
                Name = departmentMAdded.Name,
                FatherName = departmentMAdded.FatherName,
                Surname = departmentMAdded.Surname,
                Email = departmentMAdded.Email,
                PhoneNumber = departmentMAdded.PhoneNumber,
                StartTime = departmentMAdded.StartTime,
                Age = departmentMAdded.Age,
                Gender = departmentMAdded.Gender,
                Position = departmentMAdded.Position,
                formatManager = departmentMAdded.formatManager


            };

            return departmentManager;
        }
    }
}