using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna
{
    class Beer : Beverage
    {
        string Type;

        public Beer(string name, string type,double price) : base(name,price)
        {
            Type = type;
        }

        public override string ToString()
        {
            return ("Pivo\t\t"+base.ToString()+$"\t\tVrsta piva:{Type}\n");
        }
    }
}
