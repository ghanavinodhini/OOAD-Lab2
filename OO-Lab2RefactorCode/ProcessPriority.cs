using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public class ProcessPriority : IProcessPriority
    {
        private readonly ILogger _logger;
       

        public ProcessPriority(ILogger logger)
        {
            _logger = logger;
           
        }
        public void ProcessPriorityByValue(IOrder order)
        {
            MessageService messageService = new MessageService(new EmailService(Factory.CreateLogger()));
            messageService.SendMessage(order.Email,
                        "Your order has been shipped",
                        $"Your order with ID {order.ID} is expected to arrive within {GetOrderPriorities(order.Priority)}", order.ID
                        );
            
            _logger.Log($"Finished processing order with order {order.ID}");
           
        }

        public int GetOrderPriorities(Priority orderPriority)
        {
            return orderPriority switch
            {
                Priority.Low => 6,
                Priority.Medium => 3,
                Priority.High => 1,
                Priority.SuperHigh => 0,
                _ => default,
            };
        }
    }
}
