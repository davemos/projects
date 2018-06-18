using System;
using System.Collections.Generic;

namespace BaZiCalculator.Models
{
    public class DataLoad
    {
        public DataLoad()
        {
            
        }

        public List<ChineseCalendarChart> LoadChineseCalendarChartData()
        {
            List<ChineseCalendarChart> chineseCalendarChartList = new List<ChineseCalendarChart>();
            ChineseCalendarChart chineseCalendarChart = new ChineseCalendarChart();
            MonthNumber monthNumber = new MonthNumber();

            chineseCalendarChart.Year.Year = 1924;chineseCalendarChart.Year.Number = 1;
            monthNumber = new MonthNumber();monthNumber.Month = "February 5";monthNumber.Number = 3;monthNumber.Time = 950;chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 4; monthNumber.Time = 413; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "April 5"; monthNumber.Number = 5; monthNumber.Time = 934; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 6; monthNumber.Time = 326; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "June 6"; monthNumber.Number = 7; monthNumber.Time = 802; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "July 7"; monthNumber.Number = 8; monthNumber.Time = 1830; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 9; monthNumber.Time = 413; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "September 8"; monthNumber.Number = 10; monthNumber.Time = 646; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "October 8"; monthNumber.Number = 11; monthNumber.Time = 953; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "November 8"; monthNumber.Number = 12; monthNumber.Time = 30; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "December 7"; monthNumber.Number = 13; monthNumber.Time = 1654; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 14; monthNumber.Time = 354; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            chineseCalendarChartList.Add(chineseCalendarChart);

            chineseCalendarChart = new ChineseCalendarChart();
            chineseCalendarChart.Year.Year = 1925; chineseCalendarChart.Year.Number = 2;
            monthNumber = new MonthNumber();monthNumber.Month = "February 4"; monthNumber.Number = 15; monthNumber.Time = 1537; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 16; monthNumber.Time = 1000; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "April 5"; monthNumber.Number = 17; monthNumber.Time = 1523; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 18; monthNumber.Time = 918; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "June 6"; monthNumber.Number = 19; monthNumber.Time = 1357; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "July 8"; monthNumber.Number = 20; monthNumber.Time = 25; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 21; monthNumber.Time = 1008; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "September 8"; monthNumber.Number = 22; monthNumber.Time = 1240; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "October 9"; monthNumber.Number = 23; monthNumber.Time = 348; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "November 8"; monthNumber.Number = 24; monthNumber.Time = 627; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "December 7"; monthNumber.Number = 25; monthNumber.Time = 2253; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 26; monthNumber.Time = 955; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            chineseCalendarChartList.Add(chineseCalendarChart);

            chineseCalendarChart = new ChineseCalendarChart();
            chineseCalendarChart.Year.Year = 1926; chineseCalendarChart.Year.Number = 3;
            monthNumber = new MonthNumber();monthNumber.Month = "February 4"; monthNumber.Number = 27; monthNumber.Time = 2139; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "March 5"; monthNumber.Number = 28; monthNumber.Time = 1649; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "April 5"; monthNumber.Number = 29; monthNumber.Time = 2119; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 30; monthNumber.Time = 1509; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "June 6"; monthNumber.Number = 31; monthNumber.Time = 1942; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "July 8"; monthNumber.Number = 32; monthNumber.Time = 606; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 33; monthNumber.Time = 1545; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "September 8"; monthNumber.Number = 34; monthNumber.Time = 1816; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "October 9"; monthNumber.Number = 35; monthNumber.Time = 925; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "November 8"; monthNumber.Number = 36; monthNumber.Time = 1208; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "December 8"; monthNumber.Number = 37; monthNumber.Time = 439; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 38; monthNumber.Time = 1545; chineseCalendarChart.MonthNumberChart.Add(monthNumber);
            chineseCalendarChartList.Add(chineseCalendarChart);

            chineseCalendarChart = new ChineseCalendarChart();
            chineseCalendarChart.Year.Year = 1927; chineseCalendarChart.Year.Number = 4;             monthNumber = new MonthNumber();monthNumber.Month = "February 5"; monthNumber.Number = 39; monthNumber.Time = 310; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 40; monthNumber.Time = 2151; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "April 6"; monthNumber.Number = 41; monthNumber.Time = 307; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 42; monthNumber.Time = 2054; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "June 7"; monthNumber.Number = 43; monthNumber.Time = 125; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "July 8"; monthNumber.Number = 44; monthNumber.Time = 1150; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 45; monthNumber.Time = 2132; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "September 9"; monthNumber.Number = 46; monthNumber.Time = 6; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "October 9"; monthNumber.Number = 47; monthNumber.Time = 1516; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "November 8"; monthNumber.Number = 48; monthNumber.Time = 1757; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "December 8"; monthNumber.Number = 49; monthNumber.Time = 1027; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 50; monthNumber.Time = 2132; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             chineseCalendarChartList.Add(chineseCalendarChart); 
            chineseCalendarChart = new ChineseCalendarChart();
            chineseCalendarChart.Year.Year = 1928; chineseCalendarChart.Year.Number = 5;             monthNumber = new MonthNumber();monthNumber.Month = "February 5"; monthNumber.Number = 51; monthNumber.Time = 917; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 52; monthNumber.Time = 338; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "April 5"; monthNumber.Number = 53; monthNumber.Time = 855; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 54; monthNumber.Time = 244; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "June 6"; monthNumber.Number = 55; monthNumber.Time = 718; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "July 7"; monthNumber.Number = 56; monthNumber.Time = 1745; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 57; monthNumber.Time = 328; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "September 8"; monthNumber.Number = 58; monthNumber.Time = 602; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "October 8"; monthNumber.Number = 59; monthNumber.Time = 2111; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "November 7"; monthNumber.Number = 60; monthNumber.Time = 2350; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "December 7"; monthNumber.Number = 1; monthNumber.Time = 1618; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 2; monthNumber.Time = 323; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             chineseCalendarChartList.Add(chineseCalendarChart); 
            chineseCalendarChart = new ChineseCalendarChart();
            chineseCalendarChart.Year.Year = 1929; chineseCalendarChart.Year.Number = 6;             monthNumber = new MonthNumber();monthNumber.Month = "February 4"; monthNumber.Number = 3; monthNumber.Time = 1509; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 4; monthNumber.Time = 932; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "April 5"; monthNumber.Number = 5; monthNumber.Time = 1452; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 6; monthNumber.Time = 841; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "June 6"; monthNumber.Number = 7; monthNumber.Time = 1311; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "July 7"; monthNumber.Number = 8; monthNumber.Time = 2332; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 9; monthNumber.Time = 909; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "September 8"; monthNumber.Number = 10; monthNumber.Time = 1140; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "October 9"; monthNumber.Number = 11; monthNumber.Time = 248; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "November 8"; monthNumber.Number = 12; monthNumber.Time = 528; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "December 7"; monthNumber.Number = 13; monthNumber.Time = 2157; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 14; monthNumber.Time = 903; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             chineseCalendarChartList.Add(chineseCalendarChart); 
            chineseCalendarChart = new ChineseCalendarChart();
            chineseCalendarChart.Year.Year = 1930; chineseCalendarChart.Year.Number = 7;             monthNumber = new MonthNumber();monthNumber.Month = "February 4"; monthNumber.Number = 15; monthNumber.Time = 2052; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 16; monthNumber.Time = 1517; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "April 5"; monthNumber.Number = 17; monthNumber.Time = 2038; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 18; monthNumber.Time = 1428; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "June 6"; monthNumber.Number = 19; monthNumber.Time = 1858; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "July 8"; monthNumber.Number = 20; monthNumber.Time = 520; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "August 9"; monthNumber.Number = 21; monthNumber.Time = 1458; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "September 9"; monthNumber.Number = 22; monthNumber.Time = 1729; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "October 8"; monthNumber.Number = 23; monthNumber.Time = 838; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "November 8"; monthNumber.Number = 24; monthNumber.Time = 1121; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "December 8"; monthNumber.Number = 25; monthNumber.Time = 351; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 26; monthNumber.Time = 1456; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             chineseCalendarChartList.Add(chineseCalendarChart); 
            chineseCalendarChart = new ChineseCalendarChart();             chineseCalendarChart.Year.Year = 1931; chineseCalendarChart.Year.Number = 8;             monthNumber = new MonthNumber();monthNumber.Month = "February 5"; monthNumber.Number = 27; monthNumber.Time = 241; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 28; monthNumber.Time = 2103; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "April 6"; monthNumber.Number = 29; monthNumber.Time = 221; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 30; monthNumber.Time = 2010; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "June 7"; monthNumber.Number = 31; monthNumber.Time = 42; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "July 8"; monthNumber.Number = 32; monthNumber.Time = 1106; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 33; monthNumber.Time = 2045; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "September 8"; monthNumber.Number = 34; monthNumber.Time = 2318; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "October 9"; monthNumber.Number = 35; monthNumber.Time = 1427; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "November 8"; monthNumber.Number = 36; monthNumber.Time = 1710; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "December 8"; monthNumber.Number = 37; monthNumber.Time = 941; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 38; monthNumber.Time = 2046; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             chineseCalendarChartList.Add(chineseCalendarChart); 
            chineseCalendarChart = new ChineseCalendarChart();
            chineseCalendarChart.Year.Year = 1932; chineseCalendarChart.Year.Number = 9;             monthNumber = new MonthNumber();monthNumber.Month = "February 5"; monthNumber.Number = 39; monthNumber.Time = 830; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "March 6"; monthNumber.Number = 40; monthNumber.Time = 250; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "April 5"; monthNumber.Number = 41; monthNumber.Time = 807; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "May 6"; monthNumber.Number = 42; monthNumber.Time = 155; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "June 6"; monthNumber.Number = 43; monthNumber.Time = 628; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "July 7"; monthNumber.Number = 44; monthNumber.Time = 1653; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "August 8"; monthNumber.Number = 45; monthNumber.Time = 232; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "September 8"; monthNumber.Number = 46; monthNumber.Time = 503; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "October 8"; monthNumber.Number = 47; monthNumber.Time = 2010; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "November 7"; monthNumber.Number = 48; monthNumber.Time = 2250; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "December 7"; monthNumber.Number = 49; monthNumber.Time = 1519; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             monthNumber = new MonthNumber();monthNumber.Month = "January 6"; monthNumber.Number = 50; monthNumber.Time = 224; chineseCalendarChart.MonthNumberChart.Add(monthNumber);             chineseCalendarChartList.Add(chineseCalendarChart);
            return chineseCalendarChartList;
        }
        public List<TwelveStageGrowthCycleChart> LoadTwelveStageGrowthCycleChartData()
        {
            List<TwelveStageGrowthCycleChart> twelveStageGrowthCycleChartList = new List<TwelveStageGrowthCycleChart>();
            TwelveStageGrowthCycleChart twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 1;
            twelveStageGrowthCycleChart.CycleName = "Birth - Chang Sheng";
            twelveStageGrowthCycleChart.CycleDescription = "Needs Energy";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Pig;twelveStageGrowthCycleChart.Wood.Percent = 80;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Tiger;twelveStageGrowthCycleChart.Fire.Percent = 80;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Tiger;twelveStageGrowthCycleChart.Earth.Percent = 50;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Snake;twelveStageGrowthCycleChart.Metal.Percent = 80;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Monkey;twelveStageGrowthCycleChart.Water.Percent = 80;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 2;
            twelveStageGrowthCycleChart.CycleName = "Childhood - Mu Yu";
            twelveStageGrowthCycleChart.CycleDescription = "Needs Energy";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Rat; twelveStageGrowthCycleChart.Wood.Percent = 50;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Rabbit; twelveStageGrowthCycleChart.Fire.Percent = 50;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Rabbit; twelveStageGrowthCycleChart.Earth.Percent = 50;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Horse; twelveStageGrowthCycleChart.Metal.Percent = 50;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Rooster; twelveStageGrowthCycleChart.Water.Percent = 50;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 3;
            twelveStageGrowthCycleChart.CycleName = "Adolescence - Guan Dai";
            twelveStageGrowthCycleChart.CycleDescription = "Needs Direction";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Ox; twelveStageGrowthCycleChart.Wood.Percent = 50;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Dragon; twelveStageGrowthCycleChart.Fire.Percent = 50;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Dragon; twelveStageGrowthCycleChart.Earth.Percent = 100;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Sheep; twelveStageGrowthCycleChart.Metal.Percent = 50;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Dog; twelveStageGrowthCycleChart.Water.Percent = 50;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 4;
            twelveStageGrowthCycleChart.CycleName = "Adulthood - Lin Guan";
            twelveStageGrowthCycleChart.CycleDescription = "Rising, Growth";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Tiger; twelveStageGrowthCycleChart.Wood.Percent = 100;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Snake; twelveStageGrowthCycleChart.Fire.Percent = 100;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Snake; twelveStageGrowthCycleChart.Earth.Percent = 100;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Monkey; twelveStageGrowthCycleChart.Metal.Percent = 100;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Pig; twelveStageGrowthCycleChart.Water.Percent = 100;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 5;
            twelveStageGrowthCycleChart.CycleName = "Prime - Di Wang";
            twelveStageGrowthCycleChart.CycleDescription = "Peak";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Rabbit; twelveStageGrowthCycleChart.Wood.Percent = 100;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Horse; twelveStageGrowthCycleChart.Fire.Percent = 100;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Horse; twelveStageGrowthCycleChart.Earth.Percent = 100;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Rooster; twelveStageGrowthCycleChart.Metal.Percent = 100;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Rat; twelveStageGrowthCycleChart.Water.Percent = 100;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 6;
            twelveStageGrowthCycleChart.CycleName = "Decline - Sui";
            twelveStageGrowthCycleChart.CycleDescription = "Harvest, Decline";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Dragon; twelveStageGrowthCycleChart.Wood.Percent = 80;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Sheep; twelveStageGrowthCycleChart.Fire.Percent = 80;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Sheep; twelveStageGrowthCycleChart.Earth.Percent = 100;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Dog; twelveStageGrowthCycleChart.Metal.Percent = 80;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Ox; twelveStageGrowthCycleChart.Water.Percent = 80;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 7;
            twelveStageGrowthCycleChart.CycleName = "Aging - Bing";
            twelveStageGrowthCycleChart.CycleDescription = "WEakening";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Snake; twelveStageGrowthCycleChart.Wood.Percent = 50;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Monkey; twelveStageGrowthCycleChart.Fire.Percent = 50;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Monkey; twelveStageGrowthCycleChart.Earth.Percent = 50;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Pig; twelveStageGrowthCycleChart.Metal.Percent = 50;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Tiger; twelveStageGrowthCycleChart.Water.Percent = 50;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 8;
            twelveStageGrowthCycleChart.CycleName = "Death - Si";
            twelveStageGrowthCycleChart.CycleDescription = "Depletion";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Horse; twelveStageGrowthCycleChart.Wood.Percent = 50;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Rooster; twelveStageGrowthCycleChart.Fire.Percent = 50;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Rooster; twelveStageGrowthCycleChart.Earth.Percent = 50;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Rat; twelveStageGrowthCycleChart.Metal.Percent = 50;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Rabbit; twelveStageGrowthCycleChart.Water.Percent = 50;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 9;
            twelveStageGrowthCycleChart.CycleName = "Dormancy - Mu";
            twelveStageGrowthCycleChart.CycleDescription = "Buried, Storing";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Sheep; twelveStageGrowthCycleChart.Wood.Percent = 80;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Dog; twelveStageGrowthCycleChart.Fire.Percent = 80;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Dog; twelveStageGrowthCycleChart.Earth.Percent = 100;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Ox; twelveStageGrowthCycleChart.Metal.Percent = 80;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Dragon; twelveStageGrowthCycleChart.Water.Percent = 80;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 10;
            twelveStageGrowthCycleChart.CycleName = "Void - Jue";
            twelveStageGrowthCycleChart.CycleDescription = "Preparation";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Monkey; twelveStageGrowthCycleChart.Wood.Percent = 50;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Pig; twelveStageGrowthCycleChart.Fire.Percent = 50;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Pig; twelveStageGrowthCycleChart.Earth.Percent = 50;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Tiger; twelveStageGrowthCycleChart.Metal.Percent = 50;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Snake; twelveStageGrowthCycleChart.Water.Percent = 50;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 11;
            twelveStageGrowthCycleChart.CycleName = "Embryo - Tai";
            twelveStageGrowthCycleChart.CycleDescription = "Beginning";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Rooster; twelveStageGrowthCycleChart.Wood.Percent = 50;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Rat; twelveStageGrowthCycleChart.Fire.Percent = 50;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Rat; twelveStageGrowthCycleChart.Earth.Percent = 50;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Rabbit; twelveStageGrowthCycleChart.Metal.Percent = 50;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Horse; twelveStageGrowthCycleChart.Water.Percent = 50;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            twelveStageGrowthCycleChart = new TwelveStageGrowthCycleChart();
            twelveStageGrowthCycleChart.Cycle = 12;
            twelveStageGrowthCycleChart.CycleName = "Pregnancy - Yang";
            twelveStageGrowthCycleChart.CycleDescription = "New creation has begun";
            twelveStageGrowthCycleChart.Wood.Animal = Animals.Dog; twelveStageGrowthCycleChart.Wood.Percent = 50;
            twelveStageGrowthCycleChart.Fire.Animal = Animals.Ox; twelveStageGrowthCycleChart.Fire.Percent = 50;
            twelveStageGrowthCycleChart.Earth.Animal = Animals.Ox; twelveStageGrowthCycleChart.Earth.Percent = 100;
            twelveStageGrowthCycleChart.Metal.Animal = Animals.Dragon; twelveStageGrowthCycleChart.Metal.Percent = 50;
            twelveStageGrowthCycleChart.Water.Animal = Animals.Sheep; twelveStageGrowthCycleChart.Water.Percent = 50;
            twelveStageGrowthCycleChartList.Add(twelveStageGrowthCycleChart);

            return twelveStageGrowthCycleChartList;
        }

        public List<HourStemAndBranchChart> LoadHourStemAndBranchChartData()
        {
            List<HourStemAndBranchChart> hourStemAndBranchChartList = new List<HourStemAndBranchChart>();
            HourStemAndBranchChart hourStemAndBranchChart = new HourStemAndBranchChart();

            HourStem hourStem = new HourStem();
            hourStem.TimeOfBirth = new TimeOfBirthRange();

            hourStemAndBranchChart.DayStems.Add(Stems.YangWood);
            hourStemAndBranchChart.DayStems.Add(Stems.YinEarth);
            hourStem.TimeOfBirth.TimeStart = 2300;hourStem.TimeOfBirth.TimeEnd = 59;hourStem.Stem = Stems.YangWood;hourStem.Animal = Animals.Rat;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 100;hourStem.TimeOfBirth.TimeEnd = 259;hourStem.Stem = Stems.YinWood;hourStem.Animal = Animals.Ox;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 300;hourStem.TimeOfBirth.TimeEnd = 459;hourStem.Stem = Stems.YangFire;hourStem.Animal = Animals.Tiger;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 500;hourStem.TimeOfBirth.TimeEnd = 659;hourStem.Stem = Stems.YinFire;hourStem.Animal = Animals.Rabbit;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 700;hourStem.TimeOfBirth.TimeEnd = 859;hourStem.Stem = Stems.YangEarth;hourStem.Animal = Animals.Dragon;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 900;hourStem.TimeOfBirth.TimeEnd = 1059;hourStem.Stem = Stems.YinEarth;hourStem.Animal = Animals.Snake;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1100;hourStem.TimeOfBirth.TimeEnd = 1259;hourStem.Stem = Stems.YangMetal;hourStem.Animal = Animals.Horse;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1300;hourStem.TimeOfBirth.TimeEnd = 1459;hourStem.Stem = Stems.YinMetal;hourStem.Animal = Animals.Sheep;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1500;hourStem.TimeOfBirth.TimeEnd = 1659;hourStem.Stem = Stems.YangWater;hourStem.Animal = Animals.Monkey;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1700;hourStem.TimeOfBirth.TimeEnd = 1859;hourStem.Stem = Stems.YinWater;hourStem.Animal = Animals.Rooster;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1900;hourStem.TimeOfBirth.TimeEnd = 2059;hourStem.Stem = Stems.YangWood;hourStem.Animal = Animals.Dog;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 2100;hourStem.TimeOfBirth.TimeEnd = 2259;hourStem.Stem = Stems.YinWood;hourStem.Animal = Animals.Pig;hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStemAndBranchChartList.Add(hourStemAndBranchChart);

            hourStemAndBranchChart = new HourStemAndBranchChart();
            hourStem = new HourStem();
            hourStem.TimeOfBirth = new TimeOfBirthRange();
            hourStemAndBranchChart.DayStems.Add(Stems.YangMetal);
            hourStemAndBranchChart.DayStems.Add(Stems.YinWood);
            hourStem.TimeOfBirth.TimeStart = 2300; hourStem.TimeOfBirth.TimeEnd = 59; hourStem.Stem = Stems.YangFire; hourStem.Animal = Animals.Rat; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 100; hourStem.TimeOfBirth.TimeEnd = 259; hourStem.Stem = Stems.YinFire; hourStem.Animal = Animals.Ox; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 300; hourStem.TimeOfBirth.TimeEnd = 459; hourStem.Stem = Stems.YangEarth; hourStem.Animal = Animals.Tiger; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 500; hourStem.TimeOfBirth.TimeEnd = 659; hourStem.Stem = Stems.YinEarth; hourStem.Animal = Animals.Rabbit; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 700; hourStem.TimeOfBirth.TimeEnd = 859; hourStem.Stem = Stems.YangMetal; hourStem.Animal = Animals.Dragon; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 900; hourStem.TimeOfBirth.TimeEnd = 1059; hourStem.Stem = Stems.YinMetal; hourStem.Animal = Animals.Snake; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1100; hourStem.TimeOfBirth.TimeEnd = 1259; hourStem.Stem = Stems.YangWater; hourStem.Animal = Animals.Horse; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1300; hourStem.TimeOfBirth.TimeEnd = 1459; hourStem.Stem = Stems.YinWater; hourStem.Animal = Animals.Sheep; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1500; hourStem.TimeOfBirth.TimeEnd = 1659; hourStem.Stem = Stems.YangWood; hourStem.Animal = Animals.Monkey; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1700; hourStem.TimeOfBirth.TimeEnd = 1859; hourStem.Stem = Stems.YinWood; hourStem.Animal = Animals.Rooster; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1900; hourStem.TimeOfBirth.TimeEnd = 2059; hourStem.Stem = Stems.YangFire; hourStem.Animal = Animals.Dog; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 2100; hourStem.TimeOfBirth.TimeEnd = 2259; hourStem.Stem = Stems.YinFire; hourStem.Animal = Animals.Pig; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStemAndBranchChartList.Add(hourStemAndBranchChart);

            hourStemAndBranchChart = new HourStemAndBranchChart();
            hourStem = new HourStem();
            hourStem.TimeOfBirth = new TimeOfBirthRange();
            hourStemAndBranchChart.DayStems.Add(Stems.YangFire);
            hourStemAndBranchChart.DayStems.Add(Stems.YinMetal);
            hourStem.TimeOfBirth.TimeStart = 2300; hourStem.TimeOfBirth.TimeEnd = 59; hourStem.Stem = Stems.YangEarth; hourStem.Animal = Animals.Rat; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 100; hourStem.TimeOfBirth.TimeEnd = 259; hourStem.Stem = Stems.YinEarth; hourStem.Animal = Animals.Ox; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 300; hourStem.TimeOfBirth.TimeEnd = 459; hourStem.Stem = Stems.YangMetal; hourStem.Animal = Animals.Tiger; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 500; hourStem.TimeOfBirth.TimeEnd = 659; hourStem.Stem = Stems.YinMetal; hourStem.Animal = Animals.Rabbit; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 700; hourStem.TimeOfBirth.TimeEnd = 859; hourStem.Stem = Stems.YangWater; hourStem.Animal = Animals.Dragon; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 900; hourStem.TimeOfBirth.TimeEnd = 1059; hourStem.Stem = Stems.YinWater; hourStem.Animal = Animals.Snake; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1100; hourStem.TimeOfBirth.TimeEnd = 1259; hourStem.Stem = Stems.YangWood; hourStem.Animal = Animals.Horse; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1300; hourStem.TimeOfBirth.TimeEnd = 1459; hourStem.Stem = Stems.YinWood; hourStem.Animal = Animals.Sheep; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1500; hourStem.TimeOfBirth.TimeEnd = 1659; hourStem.Stem = Stems.YangFire; hourStem.Animal = Animals.Monkey; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1700; hourStem.TimeOfBirth.TimeEnd = 1859; hourStem.Stem = Stems.YinFire; hourStem.Animal = Animals.Rooster; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1900; hourStem.TimeOfBirth.TimeEnd = 2059; hourStem.Stem = Stems.YangEarth; hourStem.Animal = Animals.Dog; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 2100; hourStem.TimeOfBirth.TimeEnd = 2259; hourStem.Stem = Stems.YinEarth; hourStem.Animal = Animals.Pig; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStemAndBranchChartList.Add(hourStemAndBranchChart);

            hourStemAndBranchChart = new HourStemAndBranchChart();
            hourStem = new HourStem();
            hourStem.TimeOfBirth = new TimeOfBirthRange();
            hourStemAndBranchChart.DayStems.Add(Stems.YangWater);
            hourStemAndBranchChart.DayStems.Add(Stems.YinFire);
            hourStem.TimeOfBirth.TimeStart = 2300; hourStem.TimeOfBirth.TimeEnd = 59; hourStem.Stem = Stems.YangMetal; hourStem.Animal = Animals.Rat; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 100; hourStem.TimeOfBirth.TimeEnd = 259; hourStem.Stem = Stems.YinMetal; hourStem.Animal = Animals.Ox; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 300; hourStem.TimeOfBirth.TimeEnd = 459; hourStem.Stem = Stems.YangWater; hourStem.Animal = Animals.Tiger; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 500; hourStem.TimeOfBirth.TimeEnd = 659; hourStem.Stem = Stems.YinWater; hourStem.Animal = Animals.Rabbit; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 700; hourStem.TimeOfBirth.TimeEnd = 859; hourStem.Stem = Stems.YangWood; hourStem.Animal = Animals.Dragon; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 900; hourStem.TimeOfBirth.TimeEnd = 1059; hourStem.Stem = Stems.YinWood; hourStem.Animal = Animals.Snake; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1100; hourStem.TimeOfBirth.TimeEnd = 1259; hourStem.Stem = Stems.YangFire; hourStem.Animal = Animals.Horse; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1300; hourStem.TimeOfBirth.TimeEnd = 1459; hourStem.Stem = Stems.YinFire; hourStem.Animal = Animals.Sheep; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1500; hourStem.TimeOfBirth.TimeEnd = 1659; hourStem.Stem = Stems.YangEarth; hourStem.Animal = Animals.Monkey; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1700; hourStem.TimeOfBirth.TimeEnd = 1859; hourStem.Stem = Stems.YinEarth; hourStem.Animal = Animals.Rooster; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1900; hourStem.TimeOfBirth.TimeEnd = 2059; hourStem.Stem = Stems.YangMetal; hourStem.Animal = Animals.Dog; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 2100; hourStem.TimeOfBirth.TimeEnd = 2259; hourStem.Stem = Stems.YinMetal; hourStem.Animal = Animals.Pig; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStemAndBranchChartList.Add(hourStemAndBranchChart);

            hourStemAndBranchChart = new HourStemAndBranchChart();
            hourStem = new HourStem();
            hourStem.TimeOfBirth = new TimeOfBirthRange();
            hourStemAndBranchChart.DayStems.Add(Stems.YangEarth);
            hourStemAndBranchChart.DayStems.Add(Stems.YinWater);
            hourStem.TimeOfBirth.TimeStart = 2300; hourStem.TimeOfBirth.TimeEnd = 59; hourStem.Stem = Stems.YangWater; hourStem.Animal = Animals.Rat; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 100; hourStem.TimeOfBirth.TimeEnd = 259; hourStem.Stem = Stems.YinWater; hourStem.Animal = Animals.Ox; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 300; hourStem.TimeOfBirth.TimeEnd = 459; hourStem.Stem = Stems.YangWood; hourStem.Animal = Animals.Tiger; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 500; hourStem.TimeOfBirth.TimeEnd = 659; hourStem.Stem = Stems.YinWood; hourStem.Animal = Animals.Rabbit; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 700; hourStem.TimeOfBirth.TimeEnd = 859; hourStem.Stem = Stems.YangFire; hourStem.Animal = Animals.Dragon; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 900; hourStem.TimeOfBirth.TimeEnd = 1059; hourStem.Stem = Stems.YinFire; hourStem.Animal = Animals.Snake; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1100; hourStem.TimeOfBirth.TimeEnd = 1259; hourStem.Stem = Stems.YangEarth; hourStem.Animal = Animals.Horse; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1300; hourStem.TimeOfBirth.TimeEnd = 1459; hourStem.Stem = Stems.YinEarth; hourStem.Animal = Animals.Sheep; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1500; hourStem.TimeOfBirth.TimeEnd = 1659; hourStem.Stem = Stems.YangMetal; hourStem.Animal = Animals.Monkey; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1700; hourStem.TimeOfBirth.TimeEnd = 1859; hourStem.Stem = Stems.YinMetal; hourStem.Animal = Animals.Rooster; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 1900; hourStem.TimeOfBirth.TimeEnd = 2059; hourStem.Stem = Stems.YangWater; hourStem.Animal = Animals.Dog; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStem.TimeOfBirth.TimeStart = 2100; hourStem.TimeOfBirth.TimeEnd = 2259; hourStem.Stem = Stems.YinWater; hourStem.Animal = Animals.Pig; hourStemAndBranchChart.HourStems.Add(hourStem);
            hourStemAndBranchChartList.Add(hourStemAndBranchChart);


            return hourStemAndBranchChartList;
        }
        public List<HiddenElementsChart> LoadHiddenElementsChartData()
        {
            List<HiddenElementsChart> hiddenElementsChartList = new List<HiddenElementsChart>();
            HiddenElementsChart hiddenElementsChart = new HiddenElementsChart();

            hiddenElementsChart.Animal = Animals.Pig;hiddenElementsChart.MainElement = Stems.YangWater;hiddenElementsChart.MainElementValue = 70;hiddenElementsChart.HiddenElement = Stems.YangWood;hiddenElementsChart.HiddenElementValue = 30; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Rat; hiddenElementsChart.MainElement = Stems.YinWater; hiddenElementsChart.MainElementValue = 100; hiddenElementsChart.HiddenElement = Stems.Empty; hiddenElementsChart.HiddenElementValue = 0; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Ox; hiddenElementsChart.MainElement = Stems.YinEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinWater; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinMetal; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Tiger; hiddenElementsChart.MainElement = Stems.YangWood; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YangFire; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YangEarth; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Rabbit; hiddenElementsChart.MainElement = Stems.YinWood; hiddenElementsChart.MainElementValue = 100; hiddenElementsChart.HiddenElement = Stems.Empty; hiddenElementsChart.HiddenElementValue = 0; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Dragon; hiddenElementsChart.MainElement = Stems.YangEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinWood; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinWater; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Snake; hiddenElementsChart.MainElement = Stems.YangFire; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YangEarth; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YangMetal; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Horse; hiddenElementsChart.MainElement = Stems.YinFire; hiddenElementsChart.MainElementValue = 70; hiddenElementsChart.HiddenElement = Stems.YinEarth; hiddenElementsChart.HiddenElementValue = 30; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Sheep; hiddenElementsChart.MainElement = Stems.YinEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinFire; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinWood; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Monkey; hiddenElementsChart.MainElement = Stems.YangMetal; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YangEarth; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YangWater; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Rooster; hiddenElementsChart.MainElement = Stems.YinMetal; hiddenElementsChart.MainElementValue = 100; hiddenElementsChart.HiddenElement = Stems.Empty; hiddenElementsChart.HiddenElementValue = 0; hiddenElementsChart.HiddenElement2 = Stems.Empty; hiddenElementsChart.HiddenElement2Value = 0; hiddenElementsChartList.Add(hiddenElementsChart);
            hiddenElementsChart = new HiddenElementsChart();hiddenElementsChart.Animal = Animals.Dog; hiddenElementsChart.MainElement = Stems.YangEarth; hiddenElementsChart.MainElementValue = 60; hiddenElementsChart.HiddenElement = Stems.YinMetal; hiddenElementsChart.HiddenElementValue = 20; hiddenElementsChart.HiddenElement2 = Stems.YinFire; hiddenElementsChart.HiddenElement2Value = 20; hiddenElementsChartList.Add(hiddenElementsChart);


            return hiddenElementsChartList;
        }
        public List<DayBinomialsChart> LoadDayBinomialsChartData()
        {
            List<DayBinomialsChart> dayBinomialsChartList = new List<DayBinomialsChart>();
            DayBinomialsChart dayBinomialsChart = new DayBinomialsChart();

            dayBinomialsChart.Year = 1924;dayBinomialsChart.Day1Number = 15;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1925;dayBinomialsChart.Day1Number = 21;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1926;dayBinomialsChart.Day1Number = 26;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1927;dayBinomialsChart.Day1Number = 31;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1928;dayBinomialsChart.Day1Number = 36;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1929;dayBinomialsChart.Day1Number = 42;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1930;dayBinomialsChart.Day1Number = 47;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1931;dayBinomialsChart.Day1Number = 52;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1932;dayBinomialsChart.Day1Number = 57;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1933;dayBinomialsChart.Day1Number = 3;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1934;dayBinomialsChart.Day1Number = 8;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1935;dayBinomialsChart.Day1Number = 13;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1936;dayBinomialsChart.Day1Number = 18;dayBinomialsChart.LeapYear = true;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1937;dayBinomialsChart.Day1Number = 24;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1938;dayBinomialsChart.Day1Number = 29;dayBinomialsChart.LeapYear = false;dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1939; dayBinomialsChart.Day1Number = 34; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1940; dayBinomialsChart.Day1Number = 39; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1941; dayBinomialsChart.Day1Number = 45; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1942; dayBinomialsChart.Day1Number = 50; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1943; dayBinomialsChart.Day1Number = 55; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1944; dayBinomialsChart.Day1Number = 0; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1945; dayBinomialsChart.Day1Number = 6; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1946; dayBinomialsChart.Day1Number = 11; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1947; dayBinomialsChart.Day1Number = 16; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1948; dayBinomialsChart.Day1Number = 21; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1949; dayBinomialsChart.Day1Number = 27; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1950; dayBinomialsChart.Day1Number = 32; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1951; dayBinomialsChart.Day1Number = 37; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1952; dayBinomialsChart.Day1Number = 42; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1953; dayBinomialsChart.Day1Number = 48; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1954; dayBinomialsChart.Day1Number = 53; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1955; dayBinomialsChart.Day1Number = 58; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1956; dayBinomialsChart.Day1Number = 3; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1957; dayBinomialsChart.Day1Number = 9; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1958; dayBinomialsChart.Day1Number = 14; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1959; dayBinomialsChart.Day1Number = 19; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1960; dayBinomialsChart.Day1Number = 24; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1961; dayBinomialsChart.Day1Number = 30; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1962; dayBinomialsChart.Day1Number = 35; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1963; dayBinomialsChart.Day1Number = 40; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1964; dayBinomialsChart.Day1Number = 45; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1965; dayBinomialsChart.Day1Number = 51; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1966; dayBinomialsChart.Day1Number = 56; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1967; dayBinomialsChart.Day1Number = 1; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1968; dayBinomialsChart.Day1Number = 6; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1969; dayBinomialsChart.Day1Number = 12; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1970; dayBinomialsChart.Day1Number = 17; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1971; dayBinomialsChart.Day1Number = 22; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1972; dayBinomialsChart.Day1Number = 27; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1973; dayBinomialsChart.Day1Number = 33; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1974; dayBinomialsChart.Day1Number = 38; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1975; dayBinomialsChart.Day1Number = 43; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1976; dayBinomialsChart.Day1Number = 48; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1977; dayBinomialsChart.Day1Number = 54; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1978; dayBinomialsChart.Day1Number = 59; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1979; dayBinomialsChart.Day1Number = 4; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1980; dayBinomialsChart.Day1Number = 9; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1981; dayBinomialsChart.Day1Number = 15; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1982; dayBinomialsChart.Day1Number = 20; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1983; dayBinomialsChart.Day1Number = 25; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1984; dayBinomialsChart.Day1Number = 30; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1985; dayBinomialsChart.Day1Number = 36; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1986; dayBinomialsChart.Day1Number = 41; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1987; dayBinomialsChart.Day1Number = 46; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1988; dayBinomialsChart.Day1Number = 51; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1989; dayBinomialsChart.Day1Number = 57; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1990; dayBinomialsChart.Day1Number = 2; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1991; dayBinomialsChart.Day1Number = 7; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1992; dayBinomialsChart.Day1Number = 12; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1993; dayBinomialsChart.Day1Number = 18; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1994; dayBinomialsChart.Day1Number = 23; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1995; dayBinomialsChart.Day1Number = 28; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1996; dayBinomialsChart.Day1Number = 33; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1997; dayBinomialsChart.Day1Number = 39; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1998; dayBinomialsChart.Day1Number = 44; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 1999; dayBinomialsChart.Day1Number = 49; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2000; dayBinomialsChart.Day1Number = 54; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2001; dayBinomialsChart.Day1Number = 0; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2002; dayBinomialsChart.Day1Number = 5; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2003; dayBinomialsChart.Day1Number = 10; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2004; dayBinomialsChart.Day1Number = 15; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2005; dayBinomialsChart.Day1Number = 21; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2006; dayBinomialsChart.Day1Number = 26; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2007; dayBinomialsChart.Day1Number = 31; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2008; dayBinomialsChart.Day1Number = 36; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2009; dayBinomialsChart.Day1Number = 42; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2010; dayBinomialsChart.Day1Number = 47; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2011; dayBinomialsChart.Day1Number = 52; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2012; dayBinomialsChart.Day1Number = 57; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2013; dayBinomialsChart.Day1Number = 3; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2014; dayBinomialsChart.Day1Number = 8; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2015; dayBinomialsChart.Day1Number = 13; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2016; dayBinomialsChart.Day1Number = 18; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2017; dayBinomialsChart.Day1Number = 24; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2018; dayBinomialsChart.Day1Number = 29; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2019; dayBinomialsChart.Day1Number = 34; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2020; dayBinomialsChart.Day1Number = 39; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2021; dayBinomialsChart.Day1Number = 45; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2022; dayBinomialsChart.Day1Number = 50; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2023; dayBinomialsChart.Day1Number = 55; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2024; dayBinomialsChart.Day1Number = 0; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2025; dayBinomialsChart.Day1Number = 6; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2026; dayBinomialsChart.Day1Number = 11; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2027; dayBinomialsChart.Day1Number = 16; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2028; dayBinomialsChart.Day1Number = 21; dayBinomialsChart.LeapYear = true; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2029; dayBinomialsChart.Day1Number = 27; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2030; dayBinomialsChart.Day1Number = 32; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);
            dayBinomialsChart = new DayBinomialsChart();dayBinomialsChart.Year = 2031; dayBinomialsChart.Day1Number = 37; dayBinomialsChart.LeapYear = false; dayBinomialsChartList.Add(dayBinomialsChart);

            return dayBinomialsChartList;
        }
        public List<LeapYearMonthBinomialChart> LoadLeapYearMonthBinomialChartData()
        {
            LeapYearMonthBinomialChart leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            List<LeapYearMonthBinomialChart> leapYearMonthBinomialChartList = new List<LeapYearMonthBinomialChart>();
       
            leapYearMonthBinomialChart.Month = "Jan";
            leapYearMonthBinomialChart.Number = 0;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "Feb";
            leapYearMonthBinomialChart.Number = 31;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "March";
            leapYearMonthBinomialChart.Number = 0;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "April";
            leapYearMonthBinomialChart.Number = 31;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "May";
            leapYearMonthBinomialChart.Number = 1;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "June";
            leapYearMonthBinomialChart.Number = 32;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "July";
            leapYearMonthBinomialChart.Number = 2;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "Aug";
            leapYearMonthBinomialChart.Number = 33;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "Sept";
            leapYearMonthBinomialChart.Number = 4;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "Oct";
            leapYearMonthBinomialChart.Number = 34;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
            leapYearMonthBinomialChart.Month = "Nov";
            leapYearMonthBinomialChart.Number = 5;
            leapYearMonthBinomialChartList.Add(leapYearMonthBinomialChart);
            leapYearMonthBinomialChart = new LeapYearMonthBinomialChart();
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
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "Feb";
            monthBinomialChart.Number = 31;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "March";
            monthBinomialChart.Number = 59;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "April";
            monthBinomialChart.Number = 30;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "May";
            monthBinomialChart.Number = 0;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "June";
            monthBinomialChart.Number = 31;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "July";
            monthBinomialChart.Number = 1;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "Aug";
            monthBinomialChart.Number = 32;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "Sept";
            monthBinomialChart.Number = 3;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "Oct";
            monthBinomialChart.Number = 33;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
            monthBinomialChart.Month = "Nov";
            monthBinomialChart.Number = 4;
            monthBinomialChartList.Add(monthBinomialChart); 
            monthBinomialChart = new MonthBinomialChart();
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

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 2;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 3;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 4;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 5;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 6;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 7;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 8;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 9;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 10;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 11;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 12;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 13;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 14;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 15;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 16;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 17;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 18;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 19;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 20;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 21;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);

            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 22;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 23;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 24;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 25;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 26;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 27;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 28;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 29;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 30;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 31;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 32;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 33;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 34;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 35;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 36;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 37;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 38;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 39;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 40;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 41;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 42;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 43;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 44;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 45;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 46;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 47;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 48;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Pig;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60); 
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 49;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Rat;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 50;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Ox;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 51;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Tiger;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 52;
            stemsAndBranchesCycleOf60.Stem = Stems.YinWood;
            stemsAndBranchesCycleOf60.Branch = Animals.Rabbit;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 53;
            stemsAndBranchesCycleOf60.Stem = Stems.YangFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Dragon;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 54;
            stemsAndBranchesCycleOf60.Stem = Stems.YinFire;
            stemsAndBranchesCycleOf60.Branch = Animals.Snake;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 55;
            stemsAndBranchesCycleOf60.Stem = Stems.YangEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Horse;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 56;
            stemsAndBranchesCycleOf60.Stem = Stems.YinEarth;
            stemsAndBranchesCycleOf60.Branch = Animals.Sheep;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 57;
            stemsAndBranchesCycleOf60.Stem = Stems.YangMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Monkey;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 58;
            stemsAndBranchesCycleOf60.Stem = Stems.YinMetal;
            stemsAndBranchesCycleOf60.Branch = Animals.Rooster;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
            stemsAndBranchesCycleOf60.Number = 59;
            stemsAndBranchesCycleOf60.Stem = Stems.YangWater;
            stemsAndBranchesCycleOf60.Branch = Animals.Dog;
            stemsAndBranchesCycleOf60List.Add(stemsAndBranchesCycleOf60);
            stemsAndBranchesCycleOf60 = new StemsAndBranchesCycleOf60();
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
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YinFire;
            yinYangMeridianChart.Meridian = "Heart and Pericardium";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YinEarth;
            yinYangMeridianChart.Meridian = "Spleen";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YinMetal;
            yinYangMeridianChart.Meridian = "Lung";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YinWater;
            yinYangMeridianChart.Meridian = "Kidney";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YangEarth;
            yinYangMeridianChart.Meridian = "Stomach";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YangFire;
            yinYangMeridianChart.Meridian = "Small Intestine and Triple Warmer";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YangMetal;
            yinYangMeridianChart.Meridian = "Large Intestine";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YangWater;
            yinYangMeridianChart.Meridian = "Urinary Bladder";
            yinYangMeridianChartList.Add(yinYangMeridianChart);
            yinYangMeridianChart = new YinYangMeridianChart();
            yinYangMeridianChart.Stem = Stems.YangWood;
            yinYangMeridianChart.Meridian = "Gall Bladder";
            yinYangMeridianChartList.Add(yinYangMeridianChart);

            return yinYangMeridianChartList;
        }
    }
}
