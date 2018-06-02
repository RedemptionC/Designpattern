using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Essen rabbit = new Rabbit();
            //rabbit.showStatus();
            Apple redApple = new RedApple();
            redApple.decorate(rabbit);
            //redApple.showStatus();
            Apple greenApple = new GreenApple();
            greenApple.decorate(redApple);
            //greenApple.showStatus();
            Apple yellowApple = new YellowApple();
            yellowApple.decorate(greenApple);
            yellowApple.showStatus();
            Console.WriteLine("\n去掉黄苹果");
            rabbit = yellowApple.debuf();
            rabbit.showStatus();
            Console.WriteLine("\n去掉红苹果");
            rabbit = redApple.debuf();
            rabbit.showStatus();
            //另一种写法，兔子和苹果聚合
            //Rabbit rabbit = new Rabbit();
            //Apple redApple = new RedApple();
            //Console.WriteLine("吃红苹果");

            //rabbit.getBuff(redApple);
            //rabbit.showStatus();
            //Console.WriteLine("\n吃黄苹果");

            //Apple yellowApple = new YellowApple();
            //rabbit.getBuff(yellowApple);
            //rabbit.showStatus();
            //Console.WriteLine("\n去掉红苹果");
            //rabbit.debuf(redApple);
            //rabbit.showStatus();
            Console.Read();
        }
    }
}
