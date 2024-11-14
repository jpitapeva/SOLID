namespace SOLID.OCP.GOOD_PRATICE
{
    public enum EProductType
    {
        Book = 1,
        Membership = 2,
        MembershipUpgrade = 3,
        Video = 4
    }

    public abstract class Discount
    {
        public abstract decimal Calculate(decimal price);
    }

    public class ElectronicsDiscout : Discount
    {
        public override decimal Calculate(decimal price)
        {
            return price * 0.1M;
        }
    }
}