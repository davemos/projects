using System;
namespace BaZiCalculator.Models
{
    public class TwelveStageGrowthCycleChart
    {
        public int Cycle
        {
            get;
            set;
        }
        public string CycleName
        {
            get;
            set;
        }
        public string CycleDescription
        {
            get;
            set;
        }
        public ElementCycle Wood
        {
            get;
            set;
        }
        public ElementCycle Fire
        {
            get;
            set;
        }
        public ElementCycle Earth
        {
            get;
            set;
        }
        public ElementCycle Metal
        {
            get;
            set;
        }
        public ElementCycle Water
        {
            get;
            set;
        }

        public TwelveStageGrowthCycleChart()
        {
            Wood = new ElementCycle();
            Fire = new ElementCycle();
            Earth = new ElementCycle();
            Metal = new ElementCycle();
            Water = new ElementCycle();
        }

        public class ElementCycle
        {
            public Animals Animal;
            public int Percent;
        }
    }
}
