using System;
using System.Collections.Generic;
using BaZiCalculator.Models;
                    
namespace BaZiCalculator.ViewModels
{
    public class HomeViewModel
    {
        public DateTime BirthDate
        {
            get;
            set;
        }
        public long BirthTime
        {
            get;
            set;
        }
        public int BirthYear
        {
            get;
            set;
        }
        public int BirthMonth
        {
            get;
            set;
        }
        public int BirthDay
        {
            get;
            set;
        }
        public List<YinYangMeridianChart> YinYangMeridianResult
        {
            get;
            set;
        }
        public FourPillarsTable FourPillarsResult
        {
            get;
            set;
        }
        public int TotalYin
        {
            get;
            set;
        }
        public int TotalYang
        {
            get;
            set;
        }
        public ElementTotal ElementTotals
        {
            get;
            set;
        }
        public string StatementOfExcessDeficient { get; set; }
        public HomeViewModel()
        {
            

        }
    }
}
