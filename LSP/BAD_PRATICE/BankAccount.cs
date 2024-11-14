using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.BAD_PRATICE
{
    public class BankAccount
    {
        public virtual void Withdraw(decimal amount)
        {
            // Withdraw money
        }
    }
    public class SavingAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                throw new Exception("Cannot withdraw more than 1000");
            }
            // Withdraw money
        }
    }
}
