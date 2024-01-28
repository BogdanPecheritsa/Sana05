using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    internal class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;
    }
    public double GetPriceInUAH()
    {
        return 2;
    }
}
