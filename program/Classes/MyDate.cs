using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sana05.Classes
{
    public class MyDate
    {
        protected int Year { get; set; }
        protected int Month { get; set; }
        protected int Day { get; set; }
        protected int Hours { get; set; }
        protected int Minutes { get; set; }

        public int GetYear() => Year;
        public int GetMonth() => Month;
        public int GetDay() => Day;
        public int GetHours() => Hours;
        public int GetMinutes() => Minutes;

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }

        public MyDate()
        {
            Year = 2025;
            Month = 0;
            Day = 0;
            Hours = 0;
            Minutes = 0;
        }
        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public MyDate(MyDate other)
        {
            Year = other.Year;
            Month = other.Month;
            Day = other.Day;
            Hours = other.Hours;
            Minutes = other.Minutes;
        }
    }
}
