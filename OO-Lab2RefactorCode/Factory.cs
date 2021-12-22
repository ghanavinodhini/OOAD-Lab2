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

        public static IOrderService CreateOrderService()
        {
            return new OrderService(CreateLogger(), CreateProcessPriority());
        }

        public static IMessageService CreateMessageService()
        {
            return new EmailService(CreateLogger());
        }

        public static IProcessPriority CreateProcessPriority()
        {
            return new ProcessPriority(CreateLogger());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
