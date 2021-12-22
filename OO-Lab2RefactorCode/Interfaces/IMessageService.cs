namespace OO_Lab2RefactorCode
{
    public interface IMessageService
    {
        void SendEmail(string recipient, string subject, string message, int orderID);
    }
}