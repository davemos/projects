using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{
    public class HourStemAndBranchChart
    {
        public List<Stems> DayStems
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
            DayStems = new List<Stems>();
            HourStems = new List<HourStem>();
        }

       
    }
}
