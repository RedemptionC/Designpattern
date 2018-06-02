using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder cb1 = new BenzBuilder();
            CarDirector cd1 = new CarDirector(cb1);
            cd1.createCar();
            Car c1 = cb1.getCar();
            c1.show();
            CarBuilder cb2 = new BMWBuilder();
            cd1.setBuilder(cb2);
            cd1.createCar();
            Car c2 = cb2.getCar();
            c2.show();
            Console.WriteLine(c1.Equals(c2));
            Console.Read();
        }
    }
}
