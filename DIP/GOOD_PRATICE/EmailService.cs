namespace SOLID.DIP.GOOD_PRATICE
{
    public interface IEmailService
    {
        void SendEmail(string email, string subject, string message);
    }
    public class EmailService : IEmailService
    {
        public void SendEmail(string email, string subject, string message)
        {
            //Send email
        }
    }

    public class EmailServiceFake : IEmailService
    {
        public void SendEmail(string email, string subject, string message)
        {
            //Send email
        }
    }

    public class UserService : IEmailService
    {
        public void SendEmail(string email, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}
