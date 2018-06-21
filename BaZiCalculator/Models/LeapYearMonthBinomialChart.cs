using System;
namespace BaZiCalculator.Models
{
    public class LeapYearMonthBinomialChart : IMonthBinomialChart
    {
        public int Month
        {
            get;
            set;
        }
        public int Number
        {
            get;
            set;
        }
        public LeapYearMonthBinomialChart()
        {
        }
    }
}
