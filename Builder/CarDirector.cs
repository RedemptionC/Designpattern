using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CarDirector
    {
        private CarBuilder cb;
        public void createCar()
        {
            cb.buildBody();
            cb.buildOilBox();
            cb.buildWheel();
        }
        public CarDirector(CarBuilder cb)
        {
            this.cb = cb;
        }
        public void setBuilder(CarBuilder cb)
        {
            this.cb = cb;
        }
    }
}
