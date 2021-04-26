using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class CheckingAccount : CustomerAccount
    {
        public new int Balance;
        private int depositValue;
        private int withdrawValue;
        private int checkingValue;

        //Getter and Setters for Checking
        public int CheckingValue
        {
            get { return checkingValue; }
            set
            {
                if (value > 0)
                {
                    checkingValue = value;
                }
                else
                {
                    checkingValue = 0;
                }
            }
        }

        //Getter and Setters for Withdraw
        public int WithdrawValue
        {
            get { return withdrawValue; }
            set
            {
                if (value > 0)
                {
                    withdrawValue = value;
                }
                else
                {
                    withdrawValue = 0;
                }
            }
        }

        //Getter and Setters for Deposit
        public int DepositValue
        {
            get { return depositValue; }
            set
            {
                if (value > 0)
                {
                    depositValue = value;
                }
                else
                {
                    depositValue = 0;
                }
            }
        }

        //Override for abstract methods
        public override int Deposit()
        {
            return Balance - depositValue;
        }

        //Override for abstract methods
        public override int Withdraw()
        {
            return Balance - withdrawValue;
        }
    }
}
