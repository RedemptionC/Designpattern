using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Car
    {
        private string wheel;
        private string oilbox;
        private string body;
        public void setWheel(string wheel)
        {
            this.wheel = wheel;
        }
        public string getWheel()
        {
            return wheel;
        }
        public void setOilbox(string Oilbox)
        {
            this.oilbox = Oilbox;
        }
        public string getOilbox()
        {
            return this.oilbox;
        }
        public void setbody(string body)
        {
            this.body = body;
        }
        public string getbody()
        {
            return this.body;
        }
        public void show()
        {
            Console.WriteLine(wheel +"\n" +body +"\n"+ oilbox);
        }
    }
}
