using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme.Models.ViewModel
{
    public class TestModel
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime StartTime { get; set; }

        public byte Age { get; set; }

        public string Gender { get; set; }

        public string VehicleNumber { get; set; }

        public string RTcode { get; set; }

        public byte TravelExpenses { get; set; }

        public Position Position { get; set; }

        public static explicit operator Worker(TestModel testModel)
        {
            
            Worker worker = new Worker()
            {
                Name = testModel.Name,
                Age = testModel.Age,
                Email = testModel.Email,
                FatherName = testModel.FatherName,
                Gender = testModel.Gender,
                PhoneNumber = testModel.PhoneNumber,
                RTcode = testModel.RTcode,
                StartTime = testModel.StartTime,
                Surname = testModel.Surname,
                TravelExpenses = testModel.TravelExpenses,
                VehicleNumber = testModel.VehicleNumber,
                Position = testModel.Position

            };

            return worker;
        }
    }
}