using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Milk:ingredient
    {
        public override void show()
        {
            Console.WriteLine("Milk");
        }
    }
}
