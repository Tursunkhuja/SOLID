using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.BetterDesign
{
    public class Invoice
    {
        public long Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public void AddInvoice()
        {
            try
            {
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the email
                var message = new Message() { From = "EmailFrom", To = "EmailTo", Subject = "EmailSubject", Body = "EmailBody" };
                EmailMessage.SendInvoiceEmail(message);
            }
            catch (Exception ex)
            {
                //Error Logging
                Logger.ErrorLog(ex.Message);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                //Error Logging
                Logger.ErrorLog(ex.Message);
            }
        }
    }
}
