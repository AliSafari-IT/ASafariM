using System.Net;
using System.Net.Mail;
using ASafariM.Application.Services;
using Serilog;

namespace ASafariM.Infrastructure.Services;

public class EmailService : IEmailService
{
    public void SendReactivationEmail(string email, string reason)
    {
        var mailMessage = new MailMessage("contact@asafarim.com", email)
        {
            Subject = "Account Reactivation",
            Body = $"Your account has been reactivated for the following reason: {reason}",
            IsBodyHtml = true,
        };

        using (var smtpClient = new SmtpClient("smtp.hostinger.com", 465))
        {
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("contact@asafarim.com", "AAK3+MJsnz/");

            try
            {
                smtpClient.Send(mailMessage);
                Log.Information("Reactivation email sent successfully.");
            }
            catch (SmtpException smtpEx)
            {
                // Log the exception details
                Log.Error($"SMTP error: {smtpEx.Message}");
                throw; // Rethrow or handle as needed
            }
            catch (Exception ex)
            {
                // Log general exceptions
                Log.Error($"Error sending email: {ex.Message}");
                throw; // Rethrow or handle as needed
            }
        }
    }
}