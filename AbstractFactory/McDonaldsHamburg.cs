using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class McDonaldsHamburg:hamburg
    {
        public override void show()
        {
            Console.WriteLine("McDonaldsHamburg");
        }
    }
}
