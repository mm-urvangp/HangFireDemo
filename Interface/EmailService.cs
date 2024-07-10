
namespace HangFireDemo.Interface
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string jobType, string startTime)
        {
            Console.WriteLine(jobType + "-" + startTime + "- Email Successfully Sent -"+DateTime.Now.ToLongTimeString());
        }
    }
}
