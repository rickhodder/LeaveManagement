using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace LeaveManagement.Web.Services
{
    public class EmailSender: IEmailSender
    {
        private readonly string _smtpServer;
        private readonly int _port;
        private readonly string _fromEmail;
        private readonly IEmailSender _emailSender;

        public EmailSender(string smtpServer, int port, string fromEmail)
        {
            _smtpServer = smtpServer;
            _port = port;
            _fromEmail = fromEmail;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(_fromEmail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using (var client=new SmtpClient(_smtpServer, _port))
            {
                client.Send(message);
            }

            return Task.CompletedTask;
        }
    }
}
