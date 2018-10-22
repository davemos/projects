using System;
using System.Collections.Generic;
using BaZiCalculator.Models;
                    
namespace BaZiCalculator.ViewModels
{
    public class HomeViewModel
    {
        public ChineseCalendarChart ChineseCalendar
        {
            get;
            set;
        }
        public List<StemsAndBranchesCycleOf60> StemsAndBranches
        {
            get;
            set;
        }
        public List<HourStemAndBranchChart> HourStemAndBranch
        {
            get;
            set;
        }
        public HomeViewModel()
        {
        }
    }
}
