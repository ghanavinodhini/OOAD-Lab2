using System;

namespace OO_Lab2RefactorCode
{
    class Program
    {
        static void Main(string[] args)
        {
           

            IOrderService orderServiceHigh = Factory.CreateOrderServiceHighPriority();
            IOrder orderHigh = Factory.CreateOrder();

            orderHigh.Email = "example@example.com";
            orderHigh.ID = 12321;
            orderHigh.Priority ="High";
            orderHigh.StreetAdress = "Some adress";

            orderServiceHigh.Process(orderHigh);

            IOrderService orderServiceMedium = Factory.CreateOrderServiceMediumPriority();
            IOrder orderMedium = Factory.CreateOrder();

            orderMedium.Email = "sample@medium.com";
            orderMedium.ID = 1211;
            orderMedium.Priority = "Medium";
            orderMedium.StreetAdress = "Some Address";

            orderServiceMedium.Process(orderMedium);

            IOrderService orderServiceLow = Factory.CreateOrderServiceLowPriority();
            IOrder orderLow = Factory.CreateOrder();

            orderLow.Email = "sample@low.com";
            orderLow.ID = 1211;
            orderLow.Priority = "Low";
            orderLow.StreetAdress = "Some Address";

            orderServiceLow.Process(orderLow);

        }
    }
}
