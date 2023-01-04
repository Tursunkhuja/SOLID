using SOLID.LSP.BetterDesign;
using System;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Circle();
            Console.WriteLine(circle.GetName());
            Figure rectangle = new Rectangle();
            Console.WriteLine(rectangle.GetName());
            Console.ReadKey();
        }
    }
}
