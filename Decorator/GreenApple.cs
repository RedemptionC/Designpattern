using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class GreenApple:Apple
    {
        public override void showStatus()
        {
            base.showStatus();
            Console.Write("奔跑速度快");
        }
    }
}
