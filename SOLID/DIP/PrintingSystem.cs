
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class PrintingSystem
    {
        private InvoicePrinter _invoicePrinter;
        public PrintingSystem(InvoicePrinter printer)
        {
            _invoicePrinter = printer;
        }

        public void Print(Invoice invoice)
        {
            _invoicePrinter.Print(invoice);
        }
    }
}
