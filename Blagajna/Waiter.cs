using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Waiter
    {
        string Name;
        public Waiter(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Konobar: {Name}";
        }
    }
}
