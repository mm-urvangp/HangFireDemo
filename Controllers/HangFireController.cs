using Hangfire;
using HangFireDemo.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HangFireDemo.Controllers
{
    public class HangFireController : ControllerBase
    {
        private IEmailService _emailService;
        private IBackgroundJobClient _backgroundJobClient;
        private IRecurringJobManager _recurringJobManager;

        public HangFireController(IEmailService emailService, IBackgroundJobClient backgroundJobClient, IRecurringJobManager recurringJobManager)
        {
            _emailService = emailService;
            _backgroundJobClient = backgroundJobClient;
            _recurringJobManager = recurringJobManager;
        }

        [HttpGet]
        [Route("FireAndForgetJob")]
        public string CreateFireAndForgetJob()
        {
            var jobId = _backgroundJobClient.Enqueue(() => _emailService.SendEmail("Fire-And-Forget Job", DateTime.Now.ToLongTimeString()));
            return $"Job ID: {jobId}. Welcome mail sent to the user!";
        }
    }
}
