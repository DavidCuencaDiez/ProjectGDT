using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Networking.Sockets;
namespace emailApp.Mail
{
    public class sendmail
    {
        ///***VARIABLES***///
        private string SmtpServer;
        private int Port;
        private bool Ssl;
        private string Mailfrom;
        private string Mailpassword;
        private string Mailto;
        private string Subject;
        private string Body;
        ///***CONSTRUCTOR***///
        public sendmail(string smtpServer, int port, bool ssl, string mailfrom, string mailpassword, string mailto, string subject, string body)
        {
            SmtpServer = smtpServer;
            Port = port;
            Ssl = ssl;
            Mailfrom = mailfrom;
            Mailpassword = mailpassword;
            Mailto = mailto;
            Subject = subject;
            Body = body;
        }
        ///***FUNCTIONS***///
        public async void server()
        {
            SmtpClient client = new SmtpClient(SmtpServer, Port, Mailfrom, Mailpassword, Ssl);
            SmtpMessage message = new SmtpMessage(Mailfrom, Mailto, null, Subject,Body);
            await client.SendMail(message);
        }
    }

    }

