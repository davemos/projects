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
            int yearNum = chineseCalendarChart.Find((ChineseCalendarChart obj) => obj.Year.Year == BirthYear).Year.Number;

            //step 3
            FourPillarsResult.YearStem = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == yearNum).Stem;
            FourPillarsResult.YearBranch = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == yearNum).Branch;

            //step 4
            int monthNum = Step4(chineseCalendarChart.Find((obj) => obj.Year.Year == BirthYear));

            //step 5
            FourPillarsResult.MonthStem = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == monthNum).Stem;
            FourPillarsResult.MonthBranch = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == monthNum).Branch;

            //step 6
            int dayBinomial = Step6(dayBinomialsChart.Find((obj) => obj.Year == BirthYear), monthBinomialChart.Find((obj) => obj.Month == BirthMonth));

            //step 7
            FourPillarsResult.DayStem = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == dayBinomial).Stem;
            FourPillarsResult.DayBranch = stemsAndBranchesCycleOf60.Find((obj) => obj.Number == dayBinomial).Branch;

            //step 8
            HourStemAndBranchChart hsbc = Step8(hourStemAndBranchChart, FourPillarsResult.HourStem);
            FourPillarsResult.HourStem = hsbc.HourStems.Find((obj) => obj.TimeOfBirth.TimeStart <= BirthTime && obj.TimeOfBirth.TimeEnd >= BirthTime).Stem;
            FourPillarsResult.HourBranch = hsbc.HourStems.Find((obj) => obj.TimeOfBirth.TimeStart <= BirthTime && obj.TimeOfBirth.TimeEnd >= BirthTime).Animal;

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
            int elementTotals = ElementTotals.WoodTotal + ElementTotals.FireTotal + ElementTotals.EarthTotal + ElementTotals.MetalTotal + ElementTotals.WaterTotal;
            ElementTotals.WoodPercent = ElementTotals.WoodTotal / elementTotals;
            ElementTotals.FirePercent = ElementTotals.FirePercent / elementTotals;
            ElementTotals.EarthPercent = ElementTotals.EarthPercent / elementTotals;
            ElementTotals.MetalPercent = ElementTotals.MetalPercent / elementTotals;
            ElementTotals.WaterPercent = ElementTotals.WaterPercent / elementTotals;

            // Step 14
            FourPillarsResult.DayMasterLabel = Step14(FourPillarsResult.DayStem);

            //step 16

        }

        public int Step4(ChineseCalendarChart chart)
        {
            int monthNum = chart.MonthNumberChart.Find((obj) => obj.Month.CompareTo(BirthDate) >= 0).Number;
            return monthNum;
        }

        public int Step6(DayBinomialsChart dayChart, MonthBinomialChart monthChart)
        {
            int yearBinomial = dayChart.Day1Number;
            int monthBinomial = monthChart.Number;
            int dayBinomial = BirthDay;

            int total = yearBinomial + monthBinomial + dayBinomial;

            if (total > 60) total -= 60;

            return total;
        }

        public HourStemAndBranchChart Step8(List<HourStemAndBranchChart> chart, Stems stem)
        {
            HourStemAndBranchChart hourStemAndBranchChart = new HourStemAndBranchChart();

            foreach(HourStemAndBranchChart c in chart)
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

            return total;
        }

        public string Step14(Stems stem)
        {
            string dayMaster = "";

            switch(stem)
            {
                case Stems.YinFire : 
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
        public void Step16(List<HourStemAndBranchChart> chart, List<YinYangMeridianChart> yyChart)
        {
            
            foreach (HourStemAndBranchChart hc in chart)
            {
                foreach (Stems s in hc.DayStems)
                {
                    switch (s)
                    {
                        case Stems.YinFire:
                            yyChart.Find((obj) => obj.Stem == Stems.YinFire).Count += 1;
                            TotalYin += 1;
                                break;
                        case Stems.YinWood:
                            yyChart.Find((obj) => obj.Stem == Stems.YinWood).Count += 1;
                            TotalYin += 1;
                                break;
                        case Stems.YinEarth:
                            yyChart.Find((obj) => obj.Stem == Stems.YinEarth).Count += 1;
                            TotalYin += 1;
                                break;
                        case Stems.YinMetal:
                            yyChart.Find((obj) => obj.Stem == Stems.YinMetal).Count += 1;
                            TotalYin += 1;
                                break;
                        case Stems.YinWater:
                            yyChart.Find((obj) => obj.Stem == Stems.YinWater).Count += 1;
                            TotalYin += 1;
                                break;
                        case Stems.YangFire:
                            yyChart.Find((obj) => obj.Stem == Stems.YangFire).Count += 1;
                            TotalYang += 1;
                                break;
                        case Stems.YangWood:
                            yyChart.Find((obj) => obj.Stem == Stems.YangWood).Count += 1;
                            TotalYang += 1;
                                break;
                        case Stems.YangEarth:
                            yyChart.Find((obj) => obj.Stem == Stems.YangEarth).Count += 1;
                            TotalYang += 1;
                                break;
                        case Stems.YangMetal:
                            yyChart.Find((obj) => obj.Stem == Stems.YangMetal).Count += 1;
                            TotalYang += 1;
                                break;
                        case Stems.YangWater:
                            yyChart.Find((obj) => obj.Stem == Stems.YangWater).Count += 1;
                            TotalYang += 1;
                                break;

                    }
                    foreach (HourStem h in hc.HourStems)
                    {
                        switch (h.Stem)
                        {
                            case Stems.YinFire:
                                yyChart.Find((obj) => obj.Stem == Stems.YinFire).Count += 1;
                                TotalYin += 1;
                                break;
                            case Stems.YinWood:
                                yyChart.Find((obj) => obj.Stem == Stems.YinWood).Count += 1;
                                TotalYin += 1;
                                break;
                            case Stems.YinEarth:
                                yyChart.Find((obj) => obj.Stem == Stems.YinEarth).Count += 1;
                                TotalYin += 1;
                                break;
                            case Stems.YinMetal:
                                yyChart.Find((obj) => obj.Stem == Stems.YinMetal).Count += 1;
                                TotalYin += 1;
                                break;
                            case Stems.YinWater:
                                yyChart.Find((obj) => obj.Stem == Stems.YinWater).Count += 1;
                                TotalYin += 1;
                                break;
                            case Stems.YangFire:
                                yyChart.Find((obj) => obj.Stem == Stems.YangFire).Count += 1;
                                TotalYang += 1;
                                break;
                            case Stems.YangWood:
                                yyChart.Find((obj) => obj.Stem == Stems.YangWood).Count += 1;
                                TotalYang += 1;
                                break;
                            case Stems.YangEarth:
                                yyChart.Find((obj) => obj.Stem == Stems.YangEarth).Count += 1;
                                TotalYang += 1;
                                break;
                            case Stems.YangMetal:
                                yyChart.Find((obj) => obj.Stem == Stems.YangMetal).Count += 1;
                                TotalYang += 1;
                                break;
                            case Stems.YangWater:
                                yyChart.Find((obj) => obj.Stem == Stems.YangWater).Count += 1;
                                TotalYang += 1;
                                break;

                        }
                    }
                }
            }
        }
    }
}
