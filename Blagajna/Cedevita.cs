using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna
{
    class Cedevita : Beverage
    {
        public Cedevita(string name,double price) : base(name,price)
        {
        }

        public override string ToString()
        {
            return ("Cedevita\t\t"+base.ToString()+$"\n");
        }
    }
}
