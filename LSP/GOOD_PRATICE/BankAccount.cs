namespace SOLID.LSP.GOOD_PRATICE
{
    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }

        public abstract void Withdraw(decimal amount);
    }

    public class CheckingAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient funds");
            }
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
