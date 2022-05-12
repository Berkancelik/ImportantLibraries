using System.Threading.Tasks;

namespace HangFire.Services
{
     public interface IEmailSender
    {
        Task Sender(string userId, string message);
    }
}
