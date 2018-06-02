using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class sheep:Essen
    {
        public override void showStatus()
        {
            Console.Write("羊 ");
        }
    }
}
