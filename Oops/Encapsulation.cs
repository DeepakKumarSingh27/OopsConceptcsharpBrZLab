using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Encapsulation
    {
    }
    class Account
    {
        private int accountBalance = 1000;

        //public void SetBalance(int amount)
        //{
        //    if(amount < 0)
        //    {
        //        Console.WriteLine("You can pass - val");
        //    }
        //    else
        //    {
        //        accountBalance = amount;
        //    }
        //}
        //public int GetBalance()
        //{
        //    return accountBalance;
        //}

       public int Balance
        {
           set
            {
                accountBalance = value;
            }
            get 
            {
            return accountBalance;
            }
        }

    }
}
