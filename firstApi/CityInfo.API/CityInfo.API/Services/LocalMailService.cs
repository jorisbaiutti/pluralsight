using Microsoft.Extensions.Logging;

namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private ILogger<LocalMailService> _logger;
        private string _mailTo = "admin@test.com";
        private string _mailFrom = "system@test.com";

        public LocalMailService(ILogger<LocalMailService> logger)
        {
            _logger = logger;
        }

        public void Send(string subject, string message)
        {
            _logger.LogInformation($"Mail sent {_mailFrom} to {_mailTo} with message {message} and subject {subject}");
        }
    }
}