using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public class ProcessPriority : IProcessPriority
    {
        private readonly ILogger _logger;
        private readonly IEmailService _emailService;

        public ProcessPriority(ILogger logger,  IEmailService emailService)
        {
            _logger = logger;

            _emailService = emailService;           
        }
        public void ProcessPriorityByValue(IOrder order, int duration)
        {
          //  MessageService messageService = new MessageService(new EmailService(Factory.CreateLogger()));

            _emailService.SendEmail(order.Email,
                        "Your order has been shipped",
                        $"Your order with ID {order.ID} is expected to arrive within {duration} Days", order.ID
                        );
            _logger.Log($"Finished processing order with order {order.ID} within {duration} Days");
        }

    }
}
