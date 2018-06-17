using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{
    public class HourStemAndBranchChart
    {
        public Stems DayStem
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

       
    }
}
