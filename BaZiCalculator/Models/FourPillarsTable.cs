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
        public int HourStemValue
        {
            get;
            set;
        }
        public Stems DayStem
        {
            get;
            set;
        }
        public int DayStemValue
        {
            get;
            set;
        }

        public Stems MonthStem
        {
            get;
            set;
        }
        public int MonthStemValue
        {
            get;
            set;
        }
 
        public Stems YearStem
        {
            get;
            set;
        }
        public int YearStemValue
        {
            get;
            set;
        }
        public string DayMasterLabel
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
        public HiddenElementsChart YearHiddenElements
        {
            get;
            set;
        }
        public HiddenElementsChart MonthHiddenElements
        {
            get;
            set;
        }
        public HiddenElementsChart DayHiddenElements
        {
            get;
            set;
        }
        public HiddenElementsChart HourHiddenElements
        {
            get;
            set;
        }
        public FourPillarsTable()
        {
        }
    }
}
