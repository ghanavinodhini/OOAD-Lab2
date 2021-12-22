using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public class MessageService 
    {
        private readonly IMessageService _service;

        public MessageService(IMessageService service)
        {
            _service = service;
        }
        public void SendMessage(string recipient, string subject, string message, int orderID)
        {

            _service.SendEmail(recipient, subject, message, orderID);
        }
       /* Logger logger = new Logger();
        public void SendEmail(string recipient, string subject, string message, int orderID)
        {
            // Some email sending logic we don't care about
            logger.Log($"Email sent to {recipient} about order {orderID}");
        }*/
    }
}
