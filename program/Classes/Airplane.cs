using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Classes
{
    public class Airplane
    {
        protected string StartCity { get; set; }
        protected string FinishCity { get; set; }
        protected MyDate StartDate { get; set; }
        protected MyDate FinishDate { get; set; }

        public int GetTotalTime()
        {
            TimeSpan duration = FinishDate.ToDateTime() - StartDate.ToDateTime();
            return (int)duration.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.GetYear() == FinishDate.GetYear() &&
                   StartDate.GetMonth() == FinishDate.GetMonth() &&
                   StartDate.GetDay() == FinishDate.GetDay();
        }

        public Airplane()
        {
            StartCity = "unidentified";
            FinishCity = "unidentified";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }
        public Airplane (string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public Airplane(Airplane other)
        {
            StartCity = other.StartCity;
            FinishCity = other.FinishCity;
            StartDate = other.StartDate;
            FinishDate = other.FinishDate;
        }
    }
}
