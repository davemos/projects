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
        public ElementTotal ElementTotals
        {
            get;
            set;
        }
        public List<YinYangMeridianChart> YinYangMeridianResult
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
            ChineseCalendarChart cal = chineseCalendarChart.Find((obj) => obj.Year.Year == BirthYear);
            int yearNum = 0;
            if (BirthDate < cal.MonthNumberChart[1].Month)
            {
                yearNum = chineseCalendarChart.Find((ChineseCalendarChart obj) => obj.Year.Year == BirthYear - 1).Year.Number;
            }
            else
            {
                yearNum = chineseCalendarChart.Find((ChineseCalendarChart obj) => obj.Year.Year == BirthYear).Year.Number;
            }
            //step 3
            FourPillarsResult.YearStem = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == yearNum).Stem;
            FourPillarsResult.YearBranch = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == yearNum).Branch;

            //step 4
           
            DateTime monthDay = BirthDate;
            if (BirthDate < cal.MonthNumberChart[1].Month)
            {
                monthDay = monthDay.AddYears(-1);
                cal = chineseCalendarChart.Find((obj) => obj.Year.Year == BirthYear - 1);

            }
            int monthNum = Step4(cal, monthDay);

            //step 5
            FourPillarsResult.MonthStem = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == monthNum).Stem;
            FourPillarsResult.MonthBranch = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == monthNum).Branch;

            //step 6
            DayBinomialsChart dbc = dayBinomialsChart.Find((obj) => obj.Year == BirthYear);
            IMonthBinomialChart bc;

            if (dbc.LeapYear)
                bc = leapYearMonthBinomialChart.Find((obj) => obj.Month == BirthMonth);
            else
                bc = monthBinomialChart.Find((obj) => obj.Month == BirthMonth);
            int dayBinomial = Step6(dbc, bc);

            //step 7
            FourPillarsResult.DayStem = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == dayBinomial).Stem;
            FourPillarsResult.DayBranch = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == dayBinomial).Branch;

            //step 8
            HourStemAndBranchChart hsbc = Step8(hourStemAndBranchChart, FourPillarsResult.DayStem);
            HourStem hs = new HourStem();

            if (BirthTime < 2300)
            {
                hs = hsbc.HourStems.Find((obj) => obj.TimeOfBirth.TimeStart <= BirthTime && obj.TimeOfBirth.TimeEnd >= BirthTime);

            }
            else
            {
                hs = hsbc.HourStems.Find((obj) => obj.TimeOfBirth.TimeStart <= BirthTime);
            }
            FourPillarsResult.HourStem = hs.Stem; // hsbc.HourStems.Find((obj) => obj.TimeOfBirth.TimeStart <= BirthTime && obj.TimeOfBirth.TimeEnd >= BirthTime).Stem;
            FourPillarsResult.HourBranch = hs.Animal; // hsbc.HourStems.Find((obj) => obj.TimeOfBirth.TimeStart <= BirthTime && obj.TimeOfBirth.TimeEnd >= BirthTime).Animal;

            //step 9
            HiddenElementsChart hiddenElements = new HiddenElementsChart();
            hiddenElements = hiddenElementsChart.Find((obj) => obj.Animal == FourPillarsResult.YearBranch);
            FourPillarsResult.YearHiddenElements = new HiddenElementsChart();
            FourPillarsResult.YearHiddenElements.HiddenElement = hiddenElements.MainElement;
            FourPillarsResult.YearHiddenElements.HiddenElementValue = hiddenElements.MainElementValue;
            FourPillarsResult.YearHiddenElements.HiddenElement2 = hiddenElements.HiddenElement;
            FourPillarsResult.YearHiddenElements.HiddenElement2Value = hiddenElements.HiddenElementValue;
            FourPillarsResult.YearHiddenElements.HiddenElement3 = hiddenElements.HiddenElement2;
            FourPillarsResult.YearHiddenElements.HiddenElement3Value = hiddenElements.HiddenElement2Value;

            hiddenElements = hiddenElementsChart.Find((obj) => obj.Animal == FourPillarsResult.MonthBranch);
            FourPillarsResult.MonthHiddenElements = new HiddenElementsChart();
            FourPillarsResult.MonthHiddenElements.HiddenElement = hiddenElements.MainElement;
            FourPillarsResult.MonthHiddenElements.HiddenElementValue = hiddenElements.MainElementValue;
            FourPillarsResult.MonthHiddenElements.HiddenElement2 = hiddenElements.HiddenElement;
            FourPillarsResult.MonthHiddenElements.HiddenElement2Value = hiddenElements.HiddenElementValue;
            FourPillarsResult.MonthHiddenElements.HiddenElement3 = hiddenElements.HiddenElement2;
            FourPillarsResult.MonthHiddenElements.HiddenElement3Value = hiddenElements.HiddenElement2Value;

            hiddenElements = hiddenElementsChart.Find((obj) => obj.Animal == FourPillarsResult.DayBranch);
            FourPillarsResult.DayHiddenElements = new HiddenElementsChart();
            FourPillarsResult.DayHiddenElements.HiddenElement = hiddenElements.MainElement;
            FourPillarsResult.DayHiddenElements.HiddenElementValue = hiddenElements.MainElementValue;
            FourPillarsResult.DayHiddenElements.HiddenElement2 = hiddenElements.HiddenElement;
            FourPillarsResult.DayHiddenElements.HiddenElement2Value = hiddenElements.HiddenElementValue;
            FourPillarsResult.DayHiddenElements.HiddenElement3 = hiddenElements.HiddenElement2;
            FourPillarsResult.DayHiddenElements.HiddenElement3Value = hiddenElements.HiddenElement2Value;

            hiddenElements = hiddenElementsChart.Find((obj) => obj.Animal == FourPillarsResult.HourBranch);
            FourPillarsResult.HourHiddenElements = new HiddenElementsChart();
            FourPillarsResult.HourHiddenElements.HiddenElement = hiddenElements.MainElement;
            FourPillarsResult.HourHiddenElements.HiddenElementValue = hiddenElements.MainElementValue;
            FourPillarsResult.HourHiddenElements.HiddenElement2 = hiddenElements.HiddenElement;
            FourPillarsResult.HourHiddenElements.HiddenElement2Value = hiddenElements.HiddenElementValue;
            FourPillarsResult.HourHiddenElements.HiddenElement3 = hiddenElements.HiddenElement2;
            FourPillarsResult.HourHiddenElements.HiddenElement3Value = hiddenElements.HiddenElement2Value;

            //step 10
            FourPillarsResult.YearStemValue = 100;
            FourPillarsResult.MonthStemValue = 100;
            FourPillarsResult.DayStemValue = 100;
            FourPillarsResult.HourStemValue = 100;

            //step 11
            ElementTotals = new ElementTotal();
            ElementTotals.WoodTotal = Step11(FourPillarsResult, Stems.YangWood) + Step11(FourPillarsResult, Stems.YinWood);
            ElementTotals.FireTotal = Step11(FourPillarsResult, Stems.YangFire) + Step11(FourPillarsResult, Stems.YinFire);
            ElementTotals.EarthTotal = Step11(FourPillarsResult, Stems.YangEarth) + Step11(FourPillarsResult, Stems.YinEarth);
            ElementTotals.MetalTotal = Step11(FourPillarsResult, Stems.YangMetal) + Step11(FourPillarsResult, Stems.YinMetal);
            ElementTotals.WaterTotal = Step11(FourPillarsResult, Stems.YangWater) + Step11(FourPillarsResult, Stems.YinWater);

            //step 12
            TwelveStageGrowthCycleChart twelveStage = twelveStageGrowthCycleChart.Find((obj) => obj.Wood.Animal == FourPillarsResult.MonthBranch);
            ElementTotals.WoodTotal = ElementTotals.WoodTotal * twelveStage.Wood.Percent / 100;
            ElementTotals.FireTotal = ElementTotals.FireTotal * twelveStage.Fire.Percent / 100;
            ElementTotals.EarthTotal = ElementTotals.EarthTotal * twelveStage.Earth.Percent / 100;
            ElementTotals.MetalTotal = ElementTotals.MetalTotal * twelveStage.Metal.Percent / 100;
            ElementTotals.WaterTotal = ElementTotals.WaterTotal * twelveStage.Water.Percent / 100;

            //step 13
            double elementTotals = ElementTotals.WoodTotal + ElementTotals.FireTotal + ElementTotals.EarthTotal + ElementTotals.MetalTotal + ElementTotals.WaterTotal;
            ElementTotals.WoodPercent = (int)(ElementTotals.WoodTotal / elementTotals * 100);
            ElementTotals.FirePercent = (int)(ElementTotals.FireTotal / elementTotals * 100);
            ElementTotals.EarthPercent = (int)(ElementTotals.EarthTotal / elementTotals * 100);
            ElementTotals.MetalPercent = (int)(ElementTotals.MetalTotal / elementTotals * 100);
            ElementTotals.WaterPercent = (int)(ElementTotals.WaterTotal / elementTotals * 100);

            // Step 14
            FourPillarsResult.DayMasterLabel = Step14(FourPillarsResult.DayStem);

            
            //step 16
            Step16(FourPillarsResult, yinYangMeridianChart);
            YinYangMeridianResult = yinYangMeridianChart;
        }

        public int Step4(ChineseCalendarChart chart, DateTime monthDay)
        {
            int monthNum = chart.MonthNumberChart.FindLast((obj) => obj.Month.CompareTo(monthDay) <= 0).Number;
            return monthNum;
        }

        public int Step6(DayBinomialsChart dayChart, IMonthBinomialChart monthChart)
        {
            int yearBinomial = dayChart.Day1Number;

            int monthBinomial = monthChart.Number;
            int dayBinomial = BirthDay;

            if (dayChart.LeapYear)
            {

            }
            int total = yearBinomial + monthBinomial + dayBinomial;

            if (total > 60) total -= 60;

            return total;
        }

        public HourStemAndBranchChart Step8(List<HourStemAndBranchChart> chart, Stems stem)
        {
            HourStemAndBranchChart hourStemAndBranchChart = new HourStemAndBranchChart();

            foreach (HourStemAndBranchChart c in chart)
            {
                if (c.DayStems.Contains(stem))
                {
                    hourStemAndBranchChart = c;
                    break;
                }
            }

            return hourStemAndBranchChart;
        }

        public int Step11(FourPillarsTable chart, Stems stem)
        {
            int total = 0;


            if (chart.YearStem == stem) total += chart.YearStemValue;
            if (chart.MonthStem == stem) total += chart.MonthStemValue;
            if (chart.DayStem == stem) total += chart.DayStemValue;
            if (chart.HourStem == stem) total += chart.HourStemValue;
            if (chart.YearHiddenElements.HiddenElement == stem) total += chart.YearHiddenElements.HiddenElementValue;
            if (chart.YearHiddenElements.HiddenElement2 == stem) total += chart.YearHiddenElements.HiddenElement2Value;
            if (chart.YearHiddenElements.HiddenElement3 == stem) total += chart.YearHiddenElements.HiddenElement3Value;
            if (chart.MonthHiddenElements.HiddenElement == stem) total += chart.MonthHiddenElements.HiddenElementValue;
            if (chart.MonthHiddenElements.HiddenElement2 == stem) total += chart.MonthHiddenElements.HiddenElement2Value;
            if (chart.MonthHiddenElements.HiddenElement3 == stem) total += chart.MonthHiddenElements.HiddenElement3Value;
            if (chart.DayHiddenElements.HiddenElement == stem) total += chart.DayHiddenElements.HiddenElementValue;
            if (chart.DayHiddenElements.HiddenElement2 == stem) total += chart.DayHiddenElements.HiddenElement2Value;
            if (chart.DayHiddenElements.HiddenElement3 == stem) total += chart.DayHiddenElements.HiddenElement3Value;
            if (chart.HourHiddenElements.HiddenElement == stem) total += chart.HourHiddenElements.HiddenElementValue;
            if (chart.HourHiddenElements.HiddenElement2 == stem) total += chart.HourHiddenElements.HiddenElement2Value;
            if (chart.HourHiddenElements.HiddenElement3 == stem) total += chart.HourHiddenElements.HiddenElement3Value;

            return total;
        }

        public string Step14(Stems stem)
        {
            string dayMaster = "";

            switch (stem)
            {
                case Stems.YinFire:
                    dayMaster = "Yin Fire";
                    break;
                case Stems.YinWood:
                    dayMaster = "Yin Wood";
                    break;
                case Stems.YinEarth:
                    dayMaster = "Yin Earth";
                    break;
                case Stems.YinMetal:
                    dayMaster = "Yin Metal";
                    break;
                case Stems.YinWater:
                    dayMaster = "Yin Water";
                    break;
                case Stems.YangFire:
                    dayMaster = "Yang Fire";
                    break;
                case Stems.YangWood:
                    dayMaster = "Yang Wood";
                    break;
                case Stems.YangEarth:
                    dayMaster = "Yang Earth";
                    break;
                case Stems.YangMetal:
                    dayMaster = "Yang Metal";
                    break;
                case Stems.YangWater:
                    dayMaster = "Yang Water";
                    break;

            }

            return dayMaster;
        }
        public void Step16(FourPillarsTable chart, List<YinYangMeridianChart> yyChart)
        {
            int total = 0;

            yyChart.Find((obj) => obj.Stem == chart.YearStem).Count += 1; total = chart.YearStem.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++;
            yyChart.Find((obj) => obj.Stem == chart.MonthStem).Count += 1; total = chart.MonthStem.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++;
            yyChart.Find((obj) => obj.Stem == chart.DayStem).Count += 1; total = chart.DayStem.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++;
            yyChart.Find((obj) => obj.Stem == chart.HourStem).Count += 1; total = chart.HourStem.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++;

            var hiddenElement = yyChart.Find((obj) => obj.Stem == chart.YearHiddenElements.HiddenElement); if (hiddenElement != null) { hiddenElement.Count += 1; total = chart.YearHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.YearHiddenElements.HiddenElement2); if (hiddenElement != null) { hiddenElement.Count += 1; total = chart.YearHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.YearHiddenElements.HiddenElement3); if (hiddenElement != null) { hiddenElement.Count += 1; total = chart.YearHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }

            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.MonthHiddenElements.HiddenElement); if (hiddenElement != null) {hiddenElement.Count += 1; total = chart.MonthHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.MonthHiddenElements.HiddenElement2); if (hiddenElement != null) {hiddenElement.Count += 1; total = chart.MonthHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.MonthHiddenElements.HiddenElement3); if (hiddenElement != null) {hiddenElement.Count += 1; total = chart.MonthHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }

            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.DayHiddenElements.HiddenElement); if (hiddenElement != null) {hiddenElement.Count += 1; total = chart.DayHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.DayHiddenElements.HiddenElement2); if (hiddenElement != null) {hiddenElement.Count += 1; total = chart.DayHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.DayHiddenElements.HiddenElement3); if (hiddenElement != null) {hiddenElement.Count += 1; total = chart.DayHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }

            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.HourHiddenElements.HiddenElement); if (hiddenElement != null) { hiddenElement.Count += 1; total = chart.HourHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
            hiddenElement = yyChart.Find((obj) => obj.Stem == chart.HourHiddenElements.HiddenElement2); if (hiddenElement != null) { hiddenElement.Count += 1; total = chart.HourHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }
        hiddenElement = yyChart.Find((obj) => obj.Stem == chart.HourHiddenElements.HiddenElement3); if (hiddenElement != null) { hiddenElement.Count += 1; total = chart.HourHiddenElements.HiddenElement.ToString().StartsWith("Yang") ? this.TotalYang++ : this.TotalYin++; }


        }


    }
}
