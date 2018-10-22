using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{

    public class ChineseCalendarChart
    {
        public YearNumber Year
        {
            get;
            set;
        }
        public List<MonthNumber> MonthNumberChart
        {
            get;
            set;
        }

        public ChineseCalendarChart()
        {
            Year = new YearNumber();
            MonthNumberChart = new List<MonthNumber>();
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
        public DateTime Month
        {
            get;
            set;
        }
        public int Number
        {
            get;
            set;
        }
        public long Time
        {
            get;
            set;
        }
    }
}
