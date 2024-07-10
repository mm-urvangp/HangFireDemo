namespace HangFireDemo.Interface
{
    public interface IEmailService
    {
        void SendEmail(string jobType, string startTime);
    }
}
