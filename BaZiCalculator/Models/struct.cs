using System;
namespace BaZiCalculator.Models
{
    public struct HourStem 
    {
        public Stems Stem;
        public Animals Animal;
        public TimeOfBirthRange TimeOfBirth;
    }
    public struct TimeOfBirthRange
    {
        public long TimeStart;
        public long TimeEnd;
    } 
}
