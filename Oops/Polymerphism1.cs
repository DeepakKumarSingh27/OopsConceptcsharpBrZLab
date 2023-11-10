using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
     class Polymerphism1
    {
    }
    class Animal
    {
      public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    class Dog:Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
}
