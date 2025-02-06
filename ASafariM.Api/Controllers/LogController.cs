using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogController : ControllerBase
    {
        [HttpPost]
        public IActionResult Log([FromBody] LogMessage logMessage)
        {
            var logDirectory =
                (Environment.GetEnvironmentVariable("ASAFARIM_ENV") == "production")
                    ? "/var/www/asafarim/logs"
                    : "E:/ASafariM/Logs";

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            var logFilePath = Path.Combine(logDirectory, $"ui-log-{DateTime.Now:yyyyMMdd}.txt");

            // Format the log message with a timestamp and level
            var formattedMessage =
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{logMessage.Level}] {logMessage.Message}{Environment.NewLine}";

            System.IO.File.AppendAllText(logFilePath, formattedMessage);
            return Ok();
        }
    }

    public class LogMessage
    {
        public string Message { get; set; }
        public string Level { get; set; }
    }
}
