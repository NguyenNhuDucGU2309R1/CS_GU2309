using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Console.WriteLine(square);

            square.Resize(0.5);
            Console.WriteLine(square);
            Console.ReadKey();

        }
    }
}
