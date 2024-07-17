using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna
{
    class Beverage
    {
        double Price;
        string Name;

        public double GetPrice()
        {
            return Price;
        }
        public Beverage(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Cijena: {Price}\t\t";
        }
    }
}