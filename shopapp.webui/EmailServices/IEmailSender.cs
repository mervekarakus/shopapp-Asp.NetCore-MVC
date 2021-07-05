using System.Threading.Tasks;
namespace shopapp.webui.EmailServices
{
    public interface IEmailSender
    {
                //server smtp ayarlarına bak = g mail, hotmail.
                 //api-- sendgrid

        Task SendEmailAsync(string email, string subject, string htmlMessage);



    }
}