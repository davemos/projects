using System;
namespace BaZiCalculator.Models
{
    public class DayBinomialsChart
    {
        public long Year
        {
            get;
            set;
        }
        public int Day1Number
        {
            get;
            set;
        }
        public bool LeapYear
        {
            get;
            set;
        }
        public DayBinomialsChart()
        {
        }
    }
}
