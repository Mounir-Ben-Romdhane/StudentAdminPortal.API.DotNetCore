using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.UtilityService
{
    public interface IEmailService
    {
        void SendEmail(EmailModel emailModel);

        void SendMail(MailData mailData);
    }
}
