using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme.Models.ViewModel
{
    public class FormatMAdded
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

        public RegionalManager regionalManager { get; set; }

        public static explicit operator FormatManager(FormatMAdded formatMAdded)
        {
            FormatManager formatManager = new FormatManager()
            {
                Name = formatMAdded.Name,
                FatherName = formatMAdded.FatherName,
                Surname = formatMAdded.Surname,
                Email = formatMAdded.Email,
                PhoneNumber = formatMAdded.PhoneNumber,
                StartTime = formatMAdded.StartTime,
                Age = formatMAdded.Age,
                Gender = formatMAdded.Gender,
                Position = formatMAdded.Position,
                regionalManager = formatMAdded.regionalManager


            };

            return formatManager;
        }

    }
}