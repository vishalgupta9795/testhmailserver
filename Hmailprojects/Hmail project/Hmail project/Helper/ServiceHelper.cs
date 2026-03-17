using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace Hmail_project.Helper
{
    public class ServiceHelper
    {
        public List<MimeMessage> GetInbox()
        {
            using var client = new ImapClient();

            client.Connect("localhost", 143, false);

            client.Authenticate("info@vishalEnterprises.com", "Vk9795235876@#");

            var inbox = client.Inbox;

            inbox.Open(FolderAccess.ReadOnly);

            var messages = new List<MimeMessage>();

            for (int i = 0; i < inbox.Count; i++)
            {
                messages.Add(inbox.GetMessage(i));
            }

            client.Disconnect(true);

            return messages;
        }
    }
}
