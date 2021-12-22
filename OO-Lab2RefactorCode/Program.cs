using System;

namespace OO_Lab2RefactorCode
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            //dependency inversion
            IOrder order = new Order
            {
                Email = "example@example.com",
                ID = 12321,
                Priority = Priority.SuperHigh,
                StreetAdress = "Some adress"
            };

            orderService.Process(order);

           /* orderService.Process(new Order
            {
                Email = "example@example.com",
                ID = 12321,
                Priority = Priority.SuperHigh,
                StreetAdress = "Some adress"
            });*/

        }
    }
}
