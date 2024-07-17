using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna
{
    class Coffee : Beverage
    {
        string Addition;

        public Coffee(double price,string name,string addition) : base(name,price)
        {
            Addition = addition;
        }

        public override string ToString()
        {
            return ("Nescaffe\t\t"+base.ToString()+$"\t\t{Addition} za kavu.\n");
        }
    }
}
