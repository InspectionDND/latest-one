using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme.Models.ViewModel
{
    public class RegionalMAdded
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

        public Market market { get; set; }


        public static explicit operator RegionalManager(RegionalMAdded regionalMAdded)
        {
            RegionalManager regionalManager = new RegionalManager()
            {
                Name = regionalMAdded.Name,
                FatherName = regionalMAdded.FatherName,
                Surname = regionalMAdded.Surname,
                Email = regionalMAdded.Email,
                PhoneNumber = regionalMAdded.PhoneNumber,
                StartTime = regionalMAdded.StartTime,
                Age = regionalMAdded.Age,
                Gender = regionalMAdded.Gender,
                Position = regionalMAdded.Position,
                market = regionalMAdded.market
                

            };

            return regionalManager;

        }

    }
}