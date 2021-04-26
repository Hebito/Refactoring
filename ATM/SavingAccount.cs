using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class SavingAccount : CustomerAccount
    {
        public new int Balance;
        private int depositValue;
        private int withdrawValue;
        private int savingValue;

        //Getter and Setters for Saving
        public int SavingValue
        {
            get { return savingValue; }
            set
            {
                if (value > 0)
                {
                    savingValue = value;
                }
                else
                {
                    savingValue = 0;
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

