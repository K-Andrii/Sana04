using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Classes
{
    public class Currency
    {
        protected string Name { get; set; }
        protected double ExRate { get; set; }

        public string GetName() => Name;
        public double GetExRate() => ExRate;

        public Currency()
        {
            Name = "Unknown";
            ExRate = 0.0;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(string name)
        {
            Name = name;
        }
        public Currency(Currency other)
        {
            Name = other.Name;
            ExRate = other.ExRate;
        }
    }
}
