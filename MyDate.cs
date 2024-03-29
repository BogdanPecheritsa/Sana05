﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class MyDate
    {
        public int Year {  get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public MyDate() { }

        public MyDate(MyDate myDate) 
        { 
            Year = myDate.Year;
            Month = myDate.Month;
            Day = myDate.Day;
            Hours = myDate.Hours;
            Minutes = myDate.Minutes;
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

        public MyDate(int hours, int minutes) 
        { 
            Hours = hours;
            Minutes = minutes;
        }
    }
}