namespace OO_Lab2RefactorCode
{
    public interface IEmailService
    {
        public void SendEmail(string recipient, string subject, string message, int orderID);
    }

   
}
