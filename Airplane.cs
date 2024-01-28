using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public MyDate StartDate { get; set; }
        public MyDate FinishDate { get; set; }

        public Airplane() { }
        public Airplane(Airplane airplane) { }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(MyDate startDate, MyDate finishDate)
        {
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public int GetTotalTime()
        {
            return (FinishDate.Year * 365 * 24 * 60 + FinishDate.Month * 30 * 24 * 60 + 
                FinishDate.Day * 24 * 60 + FinishDate.Hours * 60 + FinishDate.Minutes) -
           (StartDate.Year * 365 * 24 * 60 + StartDate.Month * 30 * 24 * 60 + 
           StartDate.Day * 24 * 60 + StartDate.Hours * 60 + StartDate.Minutes);
        }

        public bool IsArrivingToday()
        {
            return FinishDate.Year == StartDate.Year &&
               FinishDate.Month == StartDate.Month &&
               FinishDate.Day == StartDate.Day;
        }
    }
}