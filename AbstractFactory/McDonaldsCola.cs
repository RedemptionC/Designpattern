using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class McDonaldsCola:cola
    {
        public override void show()
        {
            Console.WriteLine("McDonaldsCola");
        }
    }
}
