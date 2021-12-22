using System;
namespace OO_Lab2RefactorCode
{
    public class Order : IOrder
    {
        public int ID { get; set; }
        public Priority Priority { get; set; }
        public string StreetAdress { get; set; }
        public string Email { get; set; }
    }
}
