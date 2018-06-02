using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class SmallCoffee:Coffee
    {
        public override void show()
        {
            Console.Write("SmallCoffee ");
            if (ingredient != null)
            {
                ingredient.show();
            }
        }
    }
}
