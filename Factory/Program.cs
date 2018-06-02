using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f1 = new AcerFactory();//HpFactory
            Laptop l1 = f1.createLaptop();
            l1.show();
            Console.Read();
        }
    }
}
