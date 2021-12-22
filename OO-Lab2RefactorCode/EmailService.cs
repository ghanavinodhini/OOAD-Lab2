using System;
namespace OO_Lab2RefactorCode
{
    public class EmailService : IMessageService
    {

        Logger logger = new Logger();


        public void SendEmail(string recipient, string subject, string message, int orderID)
        {
            // Some email sending logic we don't care about
            logger.Log($"Email sent to {recipient} about order {orderID}");
        }

    }
}
