using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public abstract class CustomerAccount
    {
        //Main Inheriting Class for Account Information
        public int Balance;
        private object ID;
        private object Account;
        private object Pin;
   
        public abstract int Withdraw();

        public abstract int Deposit();

    }
}
