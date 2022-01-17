﻿using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public class OrderServiceSuperHighPriority : IOrderService
    {
        private readonly ILogger _logger;
        private readonly IProcessPriority _processPriority;

        public OrderServiceSuperHighPriority(ILogger logger, IProcessPriority processPriority)
        {
            _logger = logger;
            _processPriority = processPriority;
        }

        public void ProcessPriorityLevel(IOrder order)
        {
            _logger.Log($"Started processing order {order.ID}");

            _processPriority.ProcessPriorityByValue(order, 0);
        }
    }
}