using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("Hey  i am default constructor");
        }
    }
    class Car1
    {
       public string carModel;
       public int carYear;
        public Car1(string carModel,int carYear)
        {
            this.carModel = carModel;
            this.carYear = carYear;
            Console.WriteLine("Hey i am parametrized Constructor");
        }
        public Car1(int carYear,string carModel)
        {
            this.carModel = carModel;
            this.carYear = carYear;
        }
    }
}
