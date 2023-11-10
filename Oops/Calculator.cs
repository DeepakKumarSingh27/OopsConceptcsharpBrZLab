using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Calculator
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
            Console.WriteLine(result);
            Console.ReadLine();
        } 
        public static void main(String[] args)
        {
            Calculator c = new Calculator();
            c.num1 = 20;
            c.num2 = 20;
            c.Add();
        }
    }
}
