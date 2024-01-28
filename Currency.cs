using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Currency
    {
        protected string Name;
        protected double ExRate;

        public Currency() { }

        public Currency(Currency currency) { }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name) 
        {
            Name = name;
        }

        public Currency(double exRate) 
        {
            ExRate = exRate;
        }
    }
}
