using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Rabbit: Essen
    {
        protected ArrayList buff = new ArrayList();
        public void getBuff(Apple apple)
        {
            buff.Add(apple);
        }
        public void debuf(Apple apple)
        {
            buff.Remove(apple);
        }
        public override void showStatus()
        {
            Console.Write("兔子 ");
            foreach (object apple in buff)
            {
                ((Apple)apple).showStatus();
            }
        }
    }
}
