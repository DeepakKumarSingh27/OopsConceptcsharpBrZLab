using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public interface A1
    {
        void m1();
    }
    public interface A2
    {
        void m2();
    }
    class B1:A1,A2
    {
       public void m1()
        {
            Console.WriteLine("Hey i am m1 Method");
        }
        public void m2()
        {
            Console.WriteLine(" Hey i am m2 Method ");
        }
    }
    internal class Interface1
    {
    }
   
}
