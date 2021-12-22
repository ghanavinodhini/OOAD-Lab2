using System;
namespace OO_Lab2RefactorCode
{
    public class ProcessPriority
    {
        public static void ProcessPriorityByValue(IOrder order)
        {
            MessageService messageService = new MessageService(new EmailService());
            messageService.SendMessage(order.Email,
                        "Your order has been shipped",
                        $"Your order with ID {order.ID} is expected to arrive within {GetOrderPriorities(order.Priority)}", order.ID
                        );
            Logger logger = new Logger();
            logger.Log($"Finished processing order with order {order.ID}");
           /* switch (order.Priority)
            {
                case Priority.Low:
                    int low = ProcessLowPriority(order);
                    SendEmail(
                        order.Email,
                        "Your order has been shipped",
                        $"Your order with ID {order.ID} is expected to arrive within {low}", order.ID
                        );
                    Log($"Finished processing order with order {order.ID}");
                    break;
                case Priority.Medium:
                    int medium = ProcessMediumPriority(order);
                    SendEmail(
                        order.Email,
                        "Your order has been shipped",
                        $"Your order with ID {order.ID} is expected to arrive within {medium}", order.ID
                        );
                    Log($"Finished processing order with order {order.ID}");
                    break;
                case Priority.High:
                    int high = ProcessHighPriority(order);
                    SendEmail(
                        order.Email,
                        "Your order has been shipped",
                        $"Your order with ID {order.ID} is expected to arrive within {high}", order.ID
                        );
                    Log($"Finished processing order with order {order.ID}");
                    break;
                default:
                    break;
            }*/
        }

        public static int GetOrderPriorities(Priority orderPriority)
        {
            switch (orderPriority)
            {
                case Priority.Low: return 6;
                case Priority.Medium: return 3;
                case Priority.High: return 1;
                case Priority.SuperHigh: return 0;
                default:return default;
                
            }
        }
    }
}
