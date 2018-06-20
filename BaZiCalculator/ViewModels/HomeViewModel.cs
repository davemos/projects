using System;
using System.Collections.Generic;
using BaZiCalculator.Models;
                    
namespace BaZiCalculator.ViewModels
{
    public class HomeViewModel
    {

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
        public HomeViewModel()
        {
            

        }
    }
}
