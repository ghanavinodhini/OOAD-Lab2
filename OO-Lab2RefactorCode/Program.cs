using System;

namespace OO_Lab2RefactorCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderService orderService = new OrderService();

            IOrderService orderService = Factory.CreateOrderService();
            IOrder order = Factory.CreateOrder();

            order.Email = "example@example.com";
            order.ID = 12321;
            order.Priority = Priority.SuperHigh;
            order.StreetAdress = "Some adress";

            //dependency inversion
            /* IOrder order = new Order
             {
                 Email = "example@example.com",
                 ID = 12321,
                 Priority = Priority.SuperHigh,
                 StreetAdress = "Some adress"
             };*/

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
