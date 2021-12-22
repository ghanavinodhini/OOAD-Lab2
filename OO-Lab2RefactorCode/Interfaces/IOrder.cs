namespace OO_Lab2RefactorCode
{
    public interface IOrder
    {
        int ID { get; set; }
        Priority Priority { get; set; }
        string StreetAdress { get; set; }
        string Email { get; set; }
    }
}