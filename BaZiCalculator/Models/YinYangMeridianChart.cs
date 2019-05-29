using System;
namespace BaZiCalculator.Models
{
    public class YinYangMeridianChart
    {
        public Stems Stem
        {
            get;
            set;
        }
        public string Meridian
        {
            get;
            set;
        }
        public int Count
        {
            get;
            set;
        }

        public int StemCount { get; set; }
        public YinYangMeridianChart()
        {
        }
    }
}
