using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{
    public class BaZiCalculator
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
        public FourPillarsTable FourPillarsResult
        {
            get;
            set;
        }
        public BaZiCalculator(DateTime birthDate, long birthTime)
        {
            FourPillarsResult = new FourPillarsTable();
            BirthDate = birthDate;
            BirthTime = birthTime;
            BirthYear = BirthDate.Year;
            BirthMonth = BirthDate.Month;
            BirthDay = BirthDate.Day;

            DataLoad dataLoad = new DataLoad();
            List<TwelveStageGrowthCycleChart> twelveStageGrowthCycleChart = dataLoad.LoadTwelveStageGrowthCycleChartData();
            List<ChineseCalendarChart> chineseCalendarChart = dataLoad.LoadChineseCalendarChartData();
            List<DayBinomialsChart> dayBinomialsChart = dataLoad.LoadDayBinomialsChartData();
            List<HourStemAndBranchChart> hourStemAndBranchChart = dataLoad.LoadHourStemAndBranchChartData();
            List<HiddenElementsChart> hiddenElementsChart = dataLoad.LoadHiddenElementsChartData();
            List<LeapYearMonthBinomialChart> leapYearMonthBinomialChart = dataLoad.LoadLeapYearMonthBinomialChartData();
            List<MonthBinomialChart> monthBinomialChart = dataLoad.LoadMonthBinomialChartData();
            List<StemsAndBranchesCycleOf60> stemsAndBranchesCycleOf60 = dataLoad.LoadStemsAndBranchesCycleOf60Data();
            List<YinYangMeridianChart> yinYangMeridianChart = dataLoad.LoadYinYangMeridianChartData();

            //step 2
            int yearNum = chineseCalendarChart.Find((ChineseCalendarChart obj) => obj.Year.Year == BirthYear).Year.Number;

            //step 3
            FourPillarsResult.YearStem = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == yearNum).Stem;
            FourPillarsResult.YearBranch = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == yearNum).Branch;

            //step 4

        }

        public void Step4(ChineseCalendarChart chart)
        {
            int monthNum = chart.MonthNumberChart.Find((obj) => obj.Month.CompareTo(BirthDate) >= 0).Number;

        }
    }
}
