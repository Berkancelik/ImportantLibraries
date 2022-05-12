using System.Threading.Tasks;

namespace HangFire.Services
{
    public class EmailSender : IEmailSender
    {
        public Task Sender(string userId, string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
