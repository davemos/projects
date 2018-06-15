using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{
    public class HourStemAndBranchChart
    {
        public string DayStem
        {
            get;
            set;
        }
        public List<HourStem> HourStems
        {
            get;
            set;
       
        }
        public HourStemAndBranchChart()
        {
        }

        struct HourStem 
        {
            string Stem;
            string Animal;
            TimeOfBirthRange TimeOfBirth;
        }
        struct TimeOfBirthRange
        {
            long TimeStart;
            long TimeEnd;
        } 
    }
}
