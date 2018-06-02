using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BMWBuilder:CarBuilder
    {
        public override void buildBody()
        {
            //Console.WriteLine("bmw build body");
            car.setbody("bmw build body");
        }
        public override void buildOilBox()
        {
            //Console.WriteLine("bmw build oilbox");
            car.setOilbox("bmw build oilbox");
        }
        public override void buildWheel()
        {
            //Console.WriteLine("bmw build wheel");
            car.setWheel("bmw build wheel");
        }
    }
}
