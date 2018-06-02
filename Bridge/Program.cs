using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ingredient i = new Lemon();
            Coffee c = new SmallCoffee();
            c.setIngredient(i);
            c.show();
            Console.Read();
        }
    }
}
