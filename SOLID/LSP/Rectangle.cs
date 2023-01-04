using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class Rectangle: Circle
    {
        public override string GetName()
        {
            return nameof(Rectangle);
        }
    }
}
