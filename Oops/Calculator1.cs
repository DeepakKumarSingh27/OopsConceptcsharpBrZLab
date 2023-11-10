using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    
    class Calculator1
    {
        
       public int num1;
       public int num2;
        int result;

       public void Add()
        {
            result = num1 + num2;
            displayResult(result);
        }
       public void Subtract()
        {
            result = num1 - num2;
            displayResult(result);
        }
       public void Multiplication()
        {
            result = num1 * num2;
            displayResult(result);
        }
       public void Div()
        {
            result = num1 / num2;
            displayResult(result);
        }
        public void displayResult(int result)
        {
            Console.WriteLine("Result is "+result);
            Console.ReadLine();
        }
        public static int findMin(int num1, int num2)
        {
            int max = num1 < num2 ? num1 : num2;
            return max;
        }
        //public static void Main(string[] args)
        //{
            //Calculator1 obj = new Calculator1();
            //obj.num1 = 20;
            //obj.num2 = 30;
            //obj.Add();
            //obj.Subtract();
            //obj.Multiplication();
            //obj.Div();
            
           // MethodExm max = new MethodExm();
            //Console.Write(max.fact(5));
          // Console.WriteLine(max.findMax(10,20));

           // max.message();
           // max.sum(2, 4);
           //Car car = new Car();
           // car.model = "BMW";
           // Console.ReadLine();
      //  }
      public static void Main(string[] args)
        {
            //  Maruti mycar = new Maruti();
            //  mycar.model = "suzuki";
            //  mycar.color = "white";
            //  mycar.price = 1222;
            //  mycar.milage = 12.4f;
            ////  mycar.speed = 33;
            //  mycar.prinInfo();
            //  mycar.printMilage();
            // // mycar.printSpeed();
            //  Console.ReadLine() ;
            // PolyMerphism ps = new PolyMerphism();
            //ps.sum(2,3);
            //ps.sum(2.2f, 4.4f);
            //  Polymerphism1 ps = new Polymerphism1();
            // Dog tommy = new Dog();
            // tommy.Eat();
            // Constructor cs = new Constructor();
            //Car1 cr = new Car1("BMW",2009);
            //Console.WriteLine("Model: " + cr.carModel);
            //Console.WriteLine("Year: " + cr.carYear);

            //Account ac= new Account();
            //ac.Balance = 100;
            //Console.WriteLine(ac.Balance);
            //B b = new B();
            //b.m1();
            //b.m2();
            // B1 b = new B1();
            //b.m1();
            //Program obj = new Program();

            //Console.WriteLine("The value of a is = " + obj.a);
            //Console.WriteLine("The value of b is = " + Program.b);
            //Console.WriteLine("The value of max is = " + Program.max);
            //Console.WriteLine("The value of k is = " + obj.k);
            Console.WriteLine("Choose \n Constructor \n interface \n AccessModifier");
            int x = Convert.ToInt32(Console.ReadLine());
           
            switch(x)
            {
                case 1:
                    Constructor cs = new Constructor();
                    Car1 cr = new Car1("BMW",2009);
                    Console.WriteLine("Model: " + cr.carModel);
                    Console.WriteLine("Year: " + cr.carYear);
                    break;
                case 2:
                    B1 b = new B1();
                    b.m1();
                    b.m2();
                    break;
                case 3:
                    Car3 c = new Car3();
                    c.model1 = "BMW";
                    c.price1 = 1;
                    c.printCarInfo();
                    break;
                default:
                    Console.WriteLine("Case Don't matched");
                    break;
            }
            Console.ReadLine();

        }

    }
    class Car3
    {
        internal string model1;
        private string color1;
        public int price1;
       public void printCarInfo()
       {
            Console.WriteLine("Model: " + model1);
            Console.WriteLine("Color: " + "White");
           Console.WriteLine("price: " + price1);
            Console.ReadLine();
        }
    //    public static void Main(string[] args)
    //    {
    //        Car car = new Car();
    //        car.model = "BMW";
    //        car.color= "red";
    //        car.price = 333;
    //        car.printCarInfo();
    //    }
    }
}
