using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using PaginaCole.Interfaces;
using PaginaCole.Models;

namespace PaginaCole.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public void SendEmail(EmailDto request)
        {
            //var body = request.Name + request.Email + request.Body;

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
            email.To.Add(MailboxAddress.Parse("nancygonzalezfallas14@gmail.com"));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = request.Body2
            };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailHost").Value, 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
