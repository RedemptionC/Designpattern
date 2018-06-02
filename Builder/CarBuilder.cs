using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class CarBuilder
    {
        protected Car car = new Car();
        public abstract void buildWheel();
        public abstract void buildOilBox();
        public abstract void buildBody();
        public Car getCar()
        {
            return car;
        }
    }
}
