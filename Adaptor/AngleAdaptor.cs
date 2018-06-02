using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class AngleAdaptor:GUI
    {
        private Angle angle;
        public AngleAdaptor(Angle angle)
        {
            this.angle = angle;
        }
        public override void draw()
        {
            angle.drawAngle();
        }
    }
}
