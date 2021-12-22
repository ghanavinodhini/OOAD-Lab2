using System;
namespace OO_Lab2RefactorCode.Interfaces
{
    public interface IProcessPriority
    {
        public void ProcessPriorityByValue(IOrder order);
        public int GetOrderPriorities(Priority orderPriority);
    }
}
