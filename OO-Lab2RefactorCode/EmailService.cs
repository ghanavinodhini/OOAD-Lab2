using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public class EmailService : IMessageService
    {
        private readonly ILogger _logger;

        public EmailService(ILogger logger)
        {
            _logger = logger;
        }
       // Logger logger = new Logger();


        public void SendEmail(string recipient, string subject, string message, int orderID)
        {
            // Some email sending logic we don't care about
            _logger.Log($"Email sent to {recipient} about order {orderID}");
        }

    }
}
