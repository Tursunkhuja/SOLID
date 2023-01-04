using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class Circle
    {
        public virtual string GetName()
        {
            return nameof(Circle);
        }
    }


}
