using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FastFoodResturant ffr = new KFC();
            cola c = ffr.MakeCola();
            hamburg h = ffr.MakeHamburg();
            c.show();
            h.show();
            Console.Read();
        }
    }
}
