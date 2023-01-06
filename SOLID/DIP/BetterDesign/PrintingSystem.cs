
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.BetterDesign
{
    public class PrintingSystem
    {
        private IPrinter _printer;
        public PrintingSystem(IPrinter printer)
        {
            _printer = printer;
        }

        public void Print(Invoice invoice)
        {
            _printer.Print(invoice);
        }
    }
}
