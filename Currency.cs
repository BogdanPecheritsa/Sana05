using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Currency
    {
        public string Name { get; set; }
        public double ExRate { get; set; }

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