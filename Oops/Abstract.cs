using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Abstract
    {
    }
   
    public abstract class A
    {
        public abstract void m1();
        public void m2()
        {
            Console.WriteLine("M2");
        }
    }
    class B:A
    {
        public override void m1()
        {
            Console.WriteLine("m1");
        }
    }
}
