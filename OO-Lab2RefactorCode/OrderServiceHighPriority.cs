using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public class OrderServiceHighPriority : IOrderService
    {
        private readonly ILogger _logger;
        private readonly IProcessPriority _processPriority;

        public OrderServiceHighPriority(ILogger logger, IProcessPriority processPriority)
        {
            _logger = logger;
            _processPriority = processPriority;
        }

        public void Process(IOrder order)
        {
            _logger.Log($"Started processing order {order.ID}");

            _processPriority.ProcessPriorityByValue(order, 1);
        }
    }
}
