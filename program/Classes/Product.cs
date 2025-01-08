using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sana05.Classes
{
    public class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected Currency Cost { get; set; }
        protected int Quantity { get; set; }
        protected string Producer { get; set; }
        protected int Weight { get; set; }
        public double GetPriceInUAH()
        {
            return Price * Cost.GetExRate();
        }
        public double GetTotalPriceInUAH()
        {
            return Price * Cost.GetExRate() * Quantity;
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }      
        public Product()
        {
            Name = "unidentified";
            Price = 0.0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "unknown";
            Weight = 0;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, int weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, int quantity, string producer)
        {
            Name = name;
            Quantity = quantity;
            Producer = producer;
        }
        public Product(Product other)
        {
            Name = other.Name;
            Price = other.Price;
            Cost = other.Cost;
            Quantity = other.Quantity;
            Producer = other.Producer;
            Weight = other.Weight;
        }
    }
}
