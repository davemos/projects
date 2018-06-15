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

        public struct HourStem 
        {
            Stems Stem;
            Animals Animal;
            TimeOfBirthRange TimeOfBirth;
        }
        public struct TimeOfBirthRange
        {
            long TimeStart;
            long TimeEnd;
        } 
    }
}
