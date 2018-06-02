using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class AcerLaptop:Laptop
    {
        public override void show()
        {
            Console.WriteLine("Acer Laptop");

        }
    }
}
