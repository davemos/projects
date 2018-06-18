using System;
namespace BaZiCalculator.Models
{
    public class FourPillarsTable
    {
        public Stems HourStem
        {
            get;
            set;
        }
        public Stems DayStem
        {
            get;
            set;
        }
        public Stems MonthStem
        {
            get;
            set;
        }
        public Stems YearStem
        {
            get;
            set;
        }

        public Animals HourBranch
        {
            get;
            set;
        }
        public Animals DayBranch
        {
            get;
            set;
        }
        public Animals MonthBranch
        {
            get;
            set;
        }
        public Animals YearBranch
        {
            get;
            set;
        }

        public FourPillarsTable()
        {
        }
    }
}
