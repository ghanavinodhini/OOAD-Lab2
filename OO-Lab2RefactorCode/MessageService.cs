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
       
    }
}
