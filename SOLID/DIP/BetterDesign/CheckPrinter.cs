using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.BetterDesign
{
    public class CheckPrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine("Printing the invoice in check printer");
        }
    }
}
