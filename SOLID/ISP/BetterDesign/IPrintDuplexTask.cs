using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.BetterDesign
{
    public interface IPrintDuplexTask
    {
        public void PrintDuplex(string PrintDuplexContent);
    }
}
