using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.BetterDesign
{
    public class Rectangle: Figure
    {
        public override string GetName()
        {
            return nameof(Rectangle);
        }
    }
}
