using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Lab2RefactorCode
{
    public class OrderService : IOrderService
    {
        public void Process(IOrder order)
        {
            Logger logger = new Logger();
            logger.Log($"Started processing order {order.ID}");

            ProcessPriority.ProcessPriorityByValue(order);

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



        /* private void Log(string message)
         {
             // Some logging logic. 
             // We output it now to the console just to see what is happening. In reality we could choose multiple ways to log, like
             // text file, event log, database or external framework.
             Console.WriteLine(message);
         }

         private int ProcessLowPriority(Order order)
         {
             // Some low speed priority logic we don't care about
             return 6;
         }

         private int ProcessMediumPriority(Order order)
         {
             // Some medium speed priority logic we don't care about
             return 3;
         }

         private int ProcessHighPriority(Order order)
         {
             // Some high speed priority logic we don't care about
             return 1;
         }

         private void SendEmail(string recipient, string subject, string message, int orderID)
         {
             // Some email sending logic we don't care about
             Log($"Email sent to {recipient} about order {orderID}");
         }*/
    }
}
