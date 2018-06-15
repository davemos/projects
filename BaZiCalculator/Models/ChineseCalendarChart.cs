using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{
    public class ChineseCalendarChart
    {
        List<YearNumber> YearNumberChart = new List<YearNumber>();
        List<MonthNumber> MonthNumberChart = new List<MonthNumber>();

        public ChineseCalendarChart()
        {
        }
    }

    public class YearNumber
    {
        public int Number
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
    }

    public class MonthNumber
    {
        public string Month
        {
            get;
            set;
        }
        public int Number
        {
            get;
            set;
        }
        public DateTime Time
        {
            get;
            set;
        }
    }
}
