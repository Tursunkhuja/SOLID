using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.BetterDesign
{
    public  class Logger
    {
        public static void ErrorLog(string errorMessage)
        {
            //System.IO.File.WriteAllText(@"c:\ErrorLog.txt", errorMessage);
            Console.WriteLine(errorMessage);
        }
    }
}
