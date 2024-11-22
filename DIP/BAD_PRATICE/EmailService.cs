namespace SOLID.DIP.BAD_PRATICE
{
    public class EmailService
    {
        public void SendEmail(string email, string subject, string message)
        {
            //Send email
        }
    }

    public class UserSerivce(EmailService emailService)
    {
        public void AddUser(string email)
        {
            //Add user
            emailService.SendEmail(email, "Welcome", "Welcome to our system");
        }
    }
}
