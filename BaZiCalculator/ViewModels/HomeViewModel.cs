using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BaZiCalculator.Models;
                    
namespace BaZiCalculator.ViewModels
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Birth Date is required.")][DataType(DataType.Date)]
        public DateTime BirthDate
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Birth Time is required.")]
        [Range(0,2400)]
        public long BirthTime
        {
            get;
            set;
        }
        public bool NoBirthTime { get; set; }
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
        public int TotalYinValue
        {
            get;
            set;
        }
        public int TotalYangValue
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
