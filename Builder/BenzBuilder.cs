using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BenzBuilder:CarBuilder
    {

        public override void buildBody()
        {
            //Console.WriteLine("benz build body");
            car.setbody("benz build body");
        }
        public override void buildOilBox()
        {
            //Console.WriteLine("benz build oil box");
            car.setOilbox("benz build oil box");
        }
        public override void buildWheel()
        {
            //Console.WriteLine("benz build body");
            car.setWheel("benz build wheel");
        }
    }
}
