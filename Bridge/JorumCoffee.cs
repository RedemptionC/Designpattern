using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class JorumCoffee:Coffee
    {
        public override void show()
        {
            Console.Write("JorumCoffee ");
            if (ingredient != null)
            {
                ingredient.show();
            }
        }
    }
}
