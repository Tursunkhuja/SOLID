using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class InvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine("Printing the invoice in invoice printer");
        }
    }
}
