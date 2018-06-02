using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class YellowApple:Apple
    {
        public override void showStatus()
        {
            base.showStatus();
            Console.Write("会趟水");
        }
    }
}
