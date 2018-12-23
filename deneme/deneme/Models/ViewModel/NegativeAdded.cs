using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace deneme.Models.ViewModel
{
    public class NegativeAdded
    {
        
        public string State { get; set; }
        
        public byte Point { get; set; }

        public string Comments { get; set; }

        public string PhotoPath { get; set; }

        public string AudioPath { get; set; }

        public static explicit operator Negative(NegativeAdded negativeAdded)
        {
            Negative negative = new Negative()
            {
                State = negativeAdded.State,
                Point = negativeAdded.Point,
                Comments = negativeAdded.Comments,
                PhotoPath = negativeAdded.PhotoPath,
                AudioPath = negativeAdded.AudioPath
            };

            return negative;
        }
    }
}