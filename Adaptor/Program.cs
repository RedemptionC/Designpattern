using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI g = new AngleAdaptor(new Angle());
            g.draw();
            Console.Read();
        }
    }
}
