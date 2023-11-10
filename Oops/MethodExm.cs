using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class MethodExm
    {
        
        public int findMax(int num1,int num2)
        {
            int max = num1 > num2 ? num1 : num2;
            return max;
        }
        public  static int findMin(int num1, int num2)
        {
            int max = num1 > num2 ? num1 : num2;
            return max;
        }
        public void message()
        {
            Console.WriteLine("Hello Java");
            Console.ReadLine();
        }
        public void sum(int num1,int num2)
        {
            Console.WriteLine((num1 + num2));
            Console.ReadLine();
        }
        public void counting()
        {
            int num = 1;   
            if (num == 11)
            {
                return;
            }
            Console.Write(num+" ");
             num++;
            counting();
        }
        public int fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fact(n - 1);
        }
    }
}
