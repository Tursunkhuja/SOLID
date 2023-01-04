using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.BetterDesign
{
    public abstract class Invoice
    {
        public abstract double GetInvoiceDiscount(double amount);
    }
}
