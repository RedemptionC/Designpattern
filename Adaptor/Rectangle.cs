using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class Rectangle:GUI
    {
        public override void draw()
        {
            Console.WriteLine("draw rectangle");
        }
    }
}
