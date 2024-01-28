using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;



        public void GetTotalTime()
        {
        }

        public bool IsArrivingToday()
        { 
            return true; 
        }
    }
}

