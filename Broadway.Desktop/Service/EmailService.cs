using Broadway.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop.Service
{
    public class EmailService
    {
        public static ResponseViewModel SendEmail(string receiverEmail, string content, string subject)
        {
            var res = new ResponseViewModel();

            try
            {
                var receiver = new MailAddress(receiverEmail);
                var sender = new MailAddress("gchandaniw@gmail.com");

                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential("gchandaniw@gmail.com", "jnacyqzuyembudgm")
                };

                var msg = new MailMessage(sender, receiver)
                {
                    Subject = subject,
                    Body = content,
                };

                smtp.Send(msg);

                res.Status = true;
                res.Message = "Email Sent";
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }
    }
}