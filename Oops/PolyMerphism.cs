using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class PolyMerphism
    {
       public void sum(int  a,int b)
        {
            Console.WriteLine((a + b));
        }
       public void sum(float a,float b) 
        {
            Console.WriteLine(a + b);   
        }
    }
}
