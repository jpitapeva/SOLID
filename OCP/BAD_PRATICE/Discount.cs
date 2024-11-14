namespace SOLID.OCP.BAD_PRATICE
{
    public enum EProductType
    {
        Book = 1,
        Membership = 2,
        MembershipUpgrade = 3,
        Video = 4
    }


    public class Discount
    {
        public decimal CalculateDiscount(EProductType productType, decimal price)
        {
            decimal discount = 0;
            switch (productType)
            {
                case EProductType.Book:
                    discount = price * 0.1M;
                    break;
                case EProductType.Membership:
                    discount = price * 0.2M;
                    break;
                case EProductType.MembershipUpgrade:
                    discount = price * 0.3M;
                    break;
                case EProductType.Video:
                    discount = price * 0.4M;
                    break;
            }
            return discount;
        }
    }
}