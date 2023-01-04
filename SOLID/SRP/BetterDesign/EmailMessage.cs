using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.BetterDesign
{
    public class EmailMessage
    {
        public static void SendInvoiceEmail(Message message)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(message.From, message.To, message.Subject, message.Body);

                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                //Error Logging
                Logger.ErrorLog(ex.Message);
            }
        }

    }
}
