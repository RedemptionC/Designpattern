using DesignPattern.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AppConfig ac = AppConfig.GetAppconfig();
            ac.setParameterA("hello");
            Console.WriteLine("ac :"+ac.getParameterA());
            AppConfig ac1 = AppConfig.GetAppconfig();
            Console.WriteLine("ac1 :" + ac1.getParameterA());
            ac1.setParameterA("hello1");
            Console.WriteLine("ac :" + ac.getParameterA());
            Console.WriteLine("ac1 :" + ac1.getParameterA());
            Console.WriteLine(ac==(ac1));
            Console.ReadLine();
        }
    }
}
