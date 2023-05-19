using PaginaCole.Models;

namespace PaginaCole.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
