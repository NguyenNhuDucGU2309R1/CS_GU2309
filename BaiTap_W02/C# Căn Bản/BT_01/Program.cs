using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello:  " + yourName);
            Console.ReadKey();
        }
    }
}
