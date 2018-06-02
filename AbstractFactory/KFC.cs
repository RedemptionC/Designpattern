using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class KFC:FastFoodResturant
    {
        public override hamburg MakeHamburg()
        {
            return new KFChamburg();
        }
        public override cola MakeCola()
        {
            return new KFCcola();
        }

    }
}
