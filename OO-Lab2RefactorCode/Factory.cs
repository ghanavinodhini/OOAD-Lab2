using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public static class Factory
    {
        public static IOrder CreateOrder()
        {
            return new Order();
        }

        public static IOrderService CreateOrderServiceLowPriority()
        {
            return new OrderServiceLowPriority(CreateLogger(), CreateProcessPriority());
        }

        public static IOrderService CreateOrderServiceMediumPriority()
        {
            return new OrderServiceMediumPriority(CreateLogger(), CreateProcessPriority());
        }

        public static IOrderService CreateOrderServiceHighPriority()
        {
            return new OrderServiceHighPriority(CreateLogger(), CreateProcessPriority());
        }

        public static IEmailService CreateEmailService()
        {
            return new EmailService(CreateLogger());
        }

        public static IProcessPriority CreateProcessPriority()
        {
            return new ProcessPriority(CreateLogger(), CreateEmailService());
        }

       
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
