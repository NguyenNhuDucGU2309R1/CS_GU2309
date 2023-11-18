using CGO_TH01_CLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_BT_W06_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TH01
            Console.WriteLine("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            double height = Double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Your Rectangle \n" + rectangle.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());

            #endregion
            #region TH02
            Cat cat = new Cat("20kg", "1.5", "kitty");
            cat.PrintInfo();
            #endregion
            #region TH03
            Student.Change();//calling change method
                             //creating objects
            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
            #endregion
            #region BT01
            Fan fan1 = new Fan(3, true, "yellow", 10);
            fan1.Display();
            Fan fan2 = new Fan(2, false, "blue", 5);
            Console.WriteLine(" Fan 2: "+ fan2.ToString());

            #endregion
            #region BT02
            QuickSort qS = new QuickSort();
            Random rd = new Random();
            int[] arr = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                arr[i] = rd.Next(0, 100);
            }

            Console.WriteLine("Sap xep nhanh (Quick Sort) trong C#: ");
            Console.WriteLine("-------------------------------------");

            //Console.WriteLine("\nIn mang ban dau: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();

            Time time = new Time();
            qS.Quick_Sort(arr, 0, arr.Length - 1);
            time.Stop();

            //Console.WriteLine();
            //Console.WriteLine("\nIn mang da qua sap xep: ");

            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();

            time.GetElapsedTime();
            #endregion
            Console.ReadKey();
        }
    }
}
