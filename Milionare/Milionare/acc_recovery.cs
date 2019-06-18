using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Milionare
{
    class acc_recovery
    {
        public static string sender_mail;
        public static string ver_code()
        {
            Random r = new Random();
            int r1 = r.Next(1000, 9999);
            temp_code = r1.ToString();
            return r1.ToString();
        }
        public static string temp_code="undef";
        public static void send_recovery(string email)
        {
            MailMessage maili = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            maili.From = new MailAddress("pass.code.millionaire@gmail.com");
            maili.To.Add(email);
            maili.Subject= "Verify Code";
            maili.Body = "Your code fors verification is " + ver_code() + "";
            smtpServer.Port = 587;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpServer.Credentials = new System.Net.NetworkCredential("pass.code.millionaire@gmail.com", "SuMChKUZhz6U");
            smtpServer.EnableSsl = true;
            smtpServer.Send(maili);
            
        }
    }
}
