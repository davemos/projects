using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{
    public class DataLoad
    {
        public DataLoad()
        {
            
        }

        public ChineseCalendarChart LoadChineseCalendarChartData()
        {
            ChineseCalendarChart chineseCalendarChart = new ChineseCalendarChart();

            return chineseCalendarChart;
        }
        public TwelveStageGrowthCycleChart LoadTwelveStageGrowthCycleChartData()
        {
            TwelveStageGrowthCycleChart twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = "";
            return twelveStageGrowthCycleChart;
        }

        public List<HourStemAndBranchChart> LoadHourStemAndBranchChartData()
        {
            List<HourStemAndBranchChart> hourStemAndBranchChartList = new List<HourStemAndBranchChart>();
            HourStemAndBranchChart hourStemAndBranchChart = new HourStemAndBranchChart();
            hourStemAndBranchChart.HourStems = new List<HourStem>();
            HourStem hourStem = new HourStem();
            hourStem.TimeOfBirth = new TimeOfBirthRange();

            hourStemAndBranchChart.DayStem = Stems.YangWood;
            hourStem.TimeOfBirth.TimeStart = 2300;
            hourStem.TimeOfBirth.TimeEnd = 59;
            hourStem.Stem = Stems.YangWood;
            hourStem.Animal = Animals.Rat;
            hourStemAndBranchChart.HourStems.Add(hourStem);



            return hourStemAndBranchChartList;
        }
        public List<HiddenElementsChart> LoadHiddenElementsChartData()
        {
            List<HiddenElementsChart> hiddenElementsChartList = new List<HiddenElementsChart>();
            HiddenElementsChart hiddenElementsChart = new HiddenElementsChart();

            hiddenElementsChart.Animal = Animals.Pig;hiddenElementsChart.MainElement = Stems.YangWater;hiddenElementsChart.MainElementValue = 70;hiddenElementsChart.HiddenElement = Stems.YangWood;hiddenElementsChart.HiddenElementValue = 30; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Rat; hiddenElementsChart.MainElement = Stems.YinWater; hiddenElementsChart.MainElementValue = 100; hiddenElementsChart.HiddenElement = Stems.Empty; hiddenElementsChart.HiddenElementValue = 0; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Ox; hiddenElementsChart.MainElement = Stems.YinEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinWater; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinMetal; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Tiger; hiddenElementsChart.MainElement = Stems.YangWood; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YangFire; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YangEarth; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Rabbit; hiddenElementsChart.MainElement = Stems.YinWood; hiddenElementsChart.MainElementValue = 100; hiddenElementsChart.HiddenElement = Stems.Empty; hiddenElementsChart.HiddenElementValue = 0; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Dragon; hiddenElementsChart.MainElement = Stems.YangEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinWood; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinWater; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Snake; hiddenElementsChart.MainElement = Stems.YangFire; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YangEarth; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YangMetal; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Horse; hiddenElementsChart.MainElement = Stems.YinFire; hiddenElementsChart.MainElementValue = 70; hiddenElementsChart.HiddenElement = Stems.YinEarth; hiddenElementsChart.HiddenElementValue = 30; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Sheep; hiddenElementsChart.MainElement = Stems.YinEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinFire; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinWood; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Monkey; hiddenElementsChart.MainElement = Stems.YangMetal; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YangEarth; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YangWater; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Rooster; hiddenElementsChart.MainElement = Stems.YinMetal; hiddenElementsChart.MainElementValue = 100; hiddenElementsChart.HiddenElement = Stems.Empty; hiddenElementsChart.HiddenElementValue = 0; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart.Animal = Animals.Dog; hiddenElementsChart.MainElement = Stems.YangEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinMetal; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinFire; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);


            return hiddenElementsChartList;
        }
        public List<DayBinomialsChart> LoadDayBinomialsChartData()
        {
            List<DayBinomialsChart> dayBinomialsChartList = new List<DayBinomialsChart>();
            DayBinomialsChart dayBinomialsChart = new DayBinomialsChart();

            dayBinomialsChart.Year = 1924;dayBinomialsChart.Day1Number = 15;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1925;dayBinomialsChart.Day1Number = 21;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1926;dayBinomialsChart.Day1Number = 26;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1927;dayBinomialsChart.Day1Number = 31;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1928;dayBinomialsChart.Day1Number = 36;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1929;dayBinomialsChart.Day1Number = 42;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1930;dayBinomialsChart.Day1Number = 47;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1931;dayBinomialsChart.Day1Number = 52;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1932;dayBinomialsChart.Day1Number = 57;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1933;dayBinomialsChart.Day1Number = 3;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1934;dayBinomialsChart.Day1Number = 8;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1935;dayBinomialsChart.Day1Number = 13;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1936;dayBinomialsChart.Day1Number = 18;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1937;dayBinomialsChart.Day1Number = 24;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1938;dayBinomialsChart.Day1Number = 29;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart.Year = 1939; dayBinomialsChart.Day1Number = 34; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1940; dayBinomialsChart.Day1Number = 39; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1941; dayBinomialsChart.Day1Number = 45; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1942; dayBinomialsChart.Day1Number = 50; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1943; dayBinomialsChart.Day1Number = 55; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1944; dayBinomialsChart.Day1Number = 0; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1945; dayBinomialsChart.Day1Number = 6; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1946; dayBinomialsChart.Day1Number = 11; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1947; dayBinomialsChart.Day1Number = 16; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1948; dayBinomialsChart.Day1Number = 21; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1949; dayBinomialsChart.Day1Number = 27; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1950; dayBinomialsChart.Day1Number = 32; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1951; dayBinomialsChart.Day1Number = 37; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1952; dayBinomialsChart.Day1Number = 42; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1953; dayBinomialsChart.Day1Number = 48; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart.Year = 1954; dayBinomialsChart.Day1Number = 53; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1955; dayBinomialsChart.Day1Number = 58; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1956; dayBinomialsChart.Day1Number = 3; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1957; dayBinomialsChart.Day1Number = 9; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1958; dayBinomialsChart.Day1Number = 14; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1959; dayBinomialsChart.Day1Number = 19; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1960; dayBinomialsChart.Day1Number = 24; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1961; dayBinomialsChart.Day1Number = 30; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1962; dayBinomialsChart.Day1Number = 35; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1963; dayBinomialsChart.Day1Number = 40; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1964; dayBinomialsChart.Day1Number = 45; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1965; dayBinomialsChart.Day1Number = 51; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1966; dayBinomialsChart.Day1Number = 56; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1967; dayBinomialsChart.Day1Number = 1; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1968; dayBinomialsChart.Day1Number = 6; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart.Year = 1969; dayBinomialsChart.Day1Number = 12; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1970; dayBinomialsChart.Day1Number = 17; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1971; dayBinomialsChart.Day1Number = 22; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1972; dayBinomialsChart.Day1Number = 27; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1973; dayBinomialsChart.Day1Number = 33; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1974; dayBinomialsChart.Day1Number = 38; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1975; dayBinomialsChart.Day1Number = 43; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1976; dayBinomialsChart.Day1Number = 48; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1977; dayBinomialsChart.Day1Number = 54; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1978; dayBinomialsChart.Day1Number = 59; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1979; dayBinomialsChart.Day1Number = 4; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1980; dayBinomialsChart.Day1Number = 9; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1981; dayBinomialsChart.Day1Number = 15; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1982; dayBinomialsChart.Day1Number = 20; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1983; dayBinomialsChart.Day1Number = 25; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart.Year = 1984; dayBinomialsChart.Day1Number = 30; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1985; dayBinomialsChart.Day1Number = 36; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1986; dayBinomialsChart.Day1Number = 41; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1987; dayBinomialsChart.Day1Number = 46; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1988; dayBinomialsChart.Day1Number = 51; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1989; dayBinomialsChart.Day1Number = 57; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1990; dayBinomialsChart.Day1Number = 2; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1991; dayBinomialsChart.Day1Number = 7; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1992; dayBinomialsChart.Day1Number = 12; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1993; dayBinomialsChart.Day1Number = 18; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1994; dayBinomialsChart.Day1Number = 23; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1995; dayBinomialsChart.Day1Number = 28; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1996; dayBinomialsChart.Day1Number = 33; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1997; dayBinomialsChart.Day1Number = 39; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 1998; dayBinomialsChart.Day1Number = 44; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart.Year = 1999; dayBinomialsChart.Day1Number = 49; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2000; dayBinomialsChart.Day1Number = 54; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2001; dayBinomialsChart.Day1Number = 0; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2002; dayBinomialsChart.Day1Number = 5; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2003; dayBinomialsChart.Day1Number = 10; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2004; dayBinomialsChart.Day1Number = 15; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2005; dayBinomialsChart.Day1Number = 21; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2006; dayBinomialsChart.Day1Number = 26; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2007; dayBinomialsChart.Day1Number = 31; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2008; dayBinomialsChart.Day1Number = 36; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2009; dayBinomialsChart.Day1Number = 42; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2010; dayBinomialsChart.Day1Number = 47; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2011; dayBinomialsChart.Day1Number = 52; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2012; dayBinomialsChart.Day1Number = 57; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2013; dayBinomialsChart.Day1Number = 3; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart.Year = 2014; dayBinomialsChart.Day1Number = 8; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2015; dayBinomialsChart.Day1Number = 13; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2016; dayBinomialsChart.Day1Number = 18; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2017; dayBinomialsChart.Day1Number = 24; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2018; dayBinomialsChart.Day1Number = 29; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2019; dayBinomialsChart.Day1Number = 34; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2020; dayBinomialsChart.Day1Number = 39; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2021; dayBinomialsChart.Day1Number = 45; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2022; dayBinomialsChart.Day1Number = 50; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2023; dayBinomialsChart.Day1Number = 55; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2024; dayBinomialsChart.Day1Number = 0; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2025; dayBinomialsChart.Day1Number = 6; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2026; dayBinomialsChart.Day1Number = 11; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2027; dayBinomialsChart.Day1Number = 16; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2028; dayBinomialsChart.Day1Number = 21; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2029; dayBinomialsChart.Day1Number = 27; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2030; dayBinomialsChart.Day1Number = 32; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart.Year = 2031; dayBinomialsChart.Day1Number = 37; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            return dayBinomialsChartList;
        }
        public List<LeapYearMonthBinomialChart> LoadLeapYearMonthBinomialChartData()
        {
            LeapYearMonthBinomialChart leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            List<LeapYearMonthBinomialChart> leapYearMonthBinomialChartList = new List<LeapYearMonthBinomialChart>();
       
            leapYearMonthBinomialChart.Month = "Jan";
            leapYearMonthBinomialChart.Number = 0;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "Feb";
            leapYearMonthBinomialChart.Number = 31;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "March";
            leapYearMonthBinomialChart.Number = 0;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "April";
            leapYearMonthBinomialChart.Number = 31;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "May";
            leapYearMonthBinomialChart.Number = 1;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "June";
            leapYearMonthBinomialChart.Number = 32;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "July";
            leapYearMonthBinomialChart.Number = 2;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "Aug";
            leapYearMonthBinomialChart.Number = 33;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "Sept";
            leapYearMonthBinomialChart.Number = 4;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "Oct";
            leapYearMonthBinomialChart.Number = 34;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "Nov";
            leapYearMonthBinomialChart.Number = 5;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart.Month = "Dec";
            leapYearMonthBinomialChart.Number = 35;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);

            return leapYearMonthBinomialChartList;
        }
        public List<MonthBinomialChart> LoadMonthBinomialChartData()
        {
            List<MonthBinomialChart> monthBinomialChartList = new List<MonthBinomialChart>();
            MonthBinomialChart monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "Jan";
            monthBinomialChart.Number = 0;
            monthBinomialChartList.Add(monthBinomialChart);
            monthBinomialChart.Month = "Feb";
            monthBinomialChart.Number = 31;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "March";
            monthBinomialChart.Number = 59;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "April";
            monthBinomialChart.Number = 30;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "May";
            monthBinomialChart.Number = 0;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "June";
            monthBinomialChart.Number = 31;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "July";
            monthBinomialChart.Number = 1;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "Aug";
            monthBinomialChart.Number = 32;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "Sept";
            monthBinomialChart.Number = 3;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "Oct";
            monthBinomialChart.Number = 33;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "Nov";
            monthBinomialChart.Number = 4;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart.Month = "Dec";
            monthBinomialChart.Number = 34;
            monthBinomialChartList.Add(monthBinomialChart);


            return monthBinomialChartList;
        }
        public List<StemsAndBranchesCycleOf60> LoadStemsAndBranchesCycleOf60Data()
        {
            List<StemsAndBranchesCycleOf60> stemsAndBranchesCycleOf60List = new List<StemsAndBranchesCycleOf60>();
            StemsAndBranchesCycleOf60 stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 1;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 2;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 3;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 4;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 5;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 6;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 7;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 8;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 9;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 10;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 11;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 12;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 13;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 14;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 15;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 16;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 17;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 18;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 19;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 20;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 21;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60.Number = 22;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 23;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 24;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 25;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 26;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 27;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 28;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 29;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 30;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 31;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 32;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 33;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 34;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 35;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 36;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 37;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 38;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 39;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 40;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 41;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 42;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60.Number = 43;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60.Number = 44;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60.Number = 45;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60.Number = 46;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60.Number = 47;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60.Number = 48;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60.Number = 49;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 50;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 51;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 52;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 53;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 54;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 55;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 56;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 57;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 58;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 59;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60.Number = 60;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            return stemsAndBranchesCycleOf60List;
        }
        public List<YinYangMeridianChart> LoadYinYangMeridianChartData()
        {
            List<YinYangMeridianChart> yinYangMeridianChartList = new List<YinYangMeridianChart>();
            YinYangMeridianChart yinYangMeridianChart = new YinYangMeridianChart();

            yinYangMeridianChart.Stem = Stems.YinWood;
            yinYangMeridianChart.Meridian = "Liver";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YinFire;
            yinYangMeridianChart.Meridian = "Heart and Pericardium";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YinEarth;
            yinYangMeridianChart.Meridian = "Spleen";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YinMetal;
            yinYangMeridianChart.Meridian = "Lung";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YinWater;
            yinYangMeridianChart.Meridian = "Kidney";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YangEarth;
            yinYangMeridianChart.Meridian = "Stomach";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YangFire;
            yinYangMeridianChart.Meridian = "Small Intestine and Triple Warmer";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YangMetal;
            yinYangMeridianChart.Meridian = "Large Intestine";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YangWater;
            yinYangMeridianChart.Meridian = "Urinary Bladder";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart.Stem = Stems.YangWood;
            yinYangMeridianChart.Meridian = "Gall Bladder";
            yinYangMeridianChartList.Add(yinYangMeridianChart);

            return yinYangMeridianChartList;
        }
    }
}
