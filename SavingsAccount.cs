using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OPP_Github
{
    public class SavingsAccount : BankAccount
    {
        private int balance;

        public SavingsAccount(int Balance) : base(Balance)
        {
            balance = Balance;
        }
    }
}
