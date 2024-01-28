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
        public string Name { get; set; }
        public double Price { get; set; }
        public Currency Cost { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public double Weight { get; set; }

        public Product() { }

        public Product(Product product) { }

        public Product (string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost) 
        { 
            Name = name;
            Price = price;
            Cost = cost;
        }

        public Product(int quantity, string producer, double weight) 
        { 
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }
        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
}