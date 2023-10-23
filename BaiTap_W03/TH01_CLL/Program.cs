using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TH01_CLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cau3();
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                        Console.ReadKey();

                }

            }
        }

        private static void cau2()
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
                Console.WriteLine(number + " is not a prime");
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
                    Console.ReadKey();
                }
            }
        }
        private static void cau3()
        {
            int choice = -1;
            int i=1; 
            while (choice != 0)

            { 
              while ( choice != 0)
               {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. rint the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                    
                



                    switch (i)
                {
                    case 1:
                        ;
                        Console.WriteLine("in hinh chu nhat");
                        Console.WriteLine("@* * * * * * *\r\n* * * * * * *\r\n* * * * * * *");
                    case 2:
                        Console.WriteLine("in hinh tam giac top-left, top-right, botton-left, botton-right");
                        Console.WriteLine("chieu dai cua hinh tam giac");
                            for (int i = 1; i <= 5; i++)
                            { Console.WriteLine("chieu dai cua hinh tam giac"); }
                            for (int j = 1; j < i; j++)
                            { Console.WriteLine("so luong * co trong dong"); }



                            Console.WriteLine(@"*\r\n* *\r\n* * *\r\n* * * *\r\n* * * * *");
                    case 3:
                        Console.WriteLine("in hinhf tam giac can");
                        Console.WriteLine("@");

                }




            }
            }
        }


    }
}






       

