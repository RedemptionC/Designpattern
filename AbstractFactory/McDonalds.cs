using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class McDonalds:FastFoodResturant
    {
        public override cola MakeCola()
        {
            return new McDonaldsCola();
        }
        public override hamburg MakeHamburg()
        {
            return new McDonaldsHamburg();
        }

    }
}
