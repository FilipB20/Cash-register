using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna
{
    class Rakija : Beverage
    {
        string Type;

        public Rakija(string name,double price,string type) : base(name, price)
        {
            Type = type;
        }

        public override string ToString()
        {
            return ("Rakija\t\t"+base.ToString() + $"\t\tVrsta:{Type}\n");
        }
    }
}
