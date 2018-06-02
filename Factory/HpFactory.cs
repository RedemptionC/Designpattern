using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class HpFactory:Factory
    {
        public override Laptop createLaptop()
        {
            return new HpLaptop();
        }
    }
}
