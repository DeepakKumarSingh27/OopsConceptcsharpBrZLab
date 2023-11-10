using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Car
    {
        public string model;
        public string color;
        public int price;
        public void prinInfo()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: "+color);
            Console.WriteLine("price: "+price);
        }
    }
   
    class Maruti:Car
    {
        public float milage;
        public void printMilage()
        {
            Console.WriteLine("Milage: "+milage);
        }
    }
    class Ferrari :Car
    {
        public int speed;
        public void printSpeed()
        {
            Console.WriteLine("Speed: " + speed);
        }
    }

}
