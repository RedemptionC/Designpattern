using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Apple: Essen
    {
        protected Essen rabbit;
        public void decorate(Essen essen)
        {
            this.rabbit = essen;
        }
        public override void showStatus()
        {
            if (rabbit != null)
            {
                rabbit.showStatus();
            }
        }
        public Essen debuf()
        {
            if (rabbit != null)
            {
                return rabbit;
            }
            return null;
        }
    }
}
