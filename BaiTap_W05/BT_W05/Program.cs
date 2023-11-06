using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_W05
{

    internal class Program
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }


        static void THUCHANH01()
        {


            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
                        break;
                    case 2:
                        Console.WriteLine("Enter Celsius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }
        static void THUCHANH02()
        {
            int[] arr = { 4, 12, 7, 8, 17, 6, 9 };
            Console.WriteLine("Find the min number in the array");
            Minvalue(arr);
        }
        public static int Minvalue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"The smallest number is {min} with the position {index} in the array");
            return index;
        }
        static void BaiTap01()
        {
            List<int> list = new List<int> { 2, 7, 8, 2, 2, 6, 4, 5 };
            deleteElement(list);
        }
        public static void deleteElement(List<int> list)
        {
            Console.WriteLine("Here we have the array");
            int i;
            for (i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("Which element you want to delete?");
            int delete = int.Parse(Console.ReadLine());
            int index = list.IndexOf(delete);

            if (list.Contains(delete))
            {
                Console.WriteLine($"Your input {delete} is in the list");
                list.Remove(delete);
                Console.WriteLine("Now your list is");
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Cannot find the element in the list");
            }
        }
        static void Bai_Tap02()
        {
            {

                Console.WriteLine("input a string: "); //step 1: create a string
                string name = Console.ReadLine();
                Console.WriteLine("Enter a character to count in the string: "); //step 2:ask a char user wants to count
                char inputChar = Console.ReadLine()[0]; // Read the first character of the input

                counting(name, inputChar);

            }
        }
        static void counting(string name, char inputChar)
        {
            int count = 0;
            for (int i = 0; i < name.Length; i++) //dem ky tu trung lap
            {
                if (name[i] == inputChar)
                {
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("Cannot find the letter");
            else //in ra (de ben ngoai de ko bi lap)
                Console.WriteLine($"The letter {name} appears {count} times");
        }
        static void Main(string[] args)
        {
            THUCHANH01();
            Console.ReadKey();

        }
    }
}
        

    