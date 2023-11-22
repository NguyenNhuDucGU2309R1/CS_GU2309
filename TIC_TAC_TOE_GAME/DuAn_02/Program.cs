using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_02
{
    class Program
    {
        static void Main(string[] args)
        {
              TicTacToe menu =new TicTacToe();
               menu.Menu();
            TicTacToe game = new TicTacToe();
            game.play();
            
            try
            {
                int a = int.Parse(Console.ReadLine()); //0 2 1
                Console.WriteLine(1 / a);

            }
            catch (Exception ex)
            {
                Console.Write("something wrong.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

    
}
