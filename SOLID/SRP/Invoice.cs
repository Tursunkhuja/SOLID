using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
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
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                //Error Logging
                SaveErrorMessage(ex.Message);
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
                SaveErrorMessage(ex.Message);
            }
        }

        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                //Error Logging
                SaveErrorMessage(ex.Message);
            }
        }

        private void SaveErrorMessage(string message)
        {
            System.IO.File.WriteAllText(@"c:\ErrorLog.txt", message);
        }
    }
}
