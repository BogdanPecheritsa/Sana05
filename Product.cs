using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sana05
{
    public class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;
        public double GetPriceInUAH()
        {
            return Price;
        }
        public double GetTotalPriceInUAH() 
        {
            double totalPrice = 0;
            return totalPrice;
        }
        public double GetTotalWeight()
        {
            double totalWeight = 0;
            return totalWeight;
        }
    }
}
