using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MediumCoffee:Coffee
    {
        public override void show()
        {
            Console.Write("MediumCoffee ");
            if (ingredient != null)
            {
                ingredient.show();
            }
        }
    }
}
