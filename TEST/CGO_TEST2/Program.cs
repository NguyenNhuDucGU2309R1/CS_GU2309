using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_TEST2
{
    internal class Program
    {
        public static int MinValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }

        public static List<int> MinValue2(List<int> array)
        {
            List<int> list = new List<int>() { 0 };
            int min = array[0];
            int index = 0;
            int dem = 0;
            int dem2 = 0;
            for (int i = 1; i < array.Count; i++)
            {
                dem++;
                if (array[i] < min)//tìm giá trị min mới, reset list
                {
                    min = array[i];
                    index = i;
                    list.Clear();

                    dem2 += 4;
                    //list.Add(i); 
                }
                //else
                if (array[i] == min) // tìm các giá trị trùng với min
                {
                    list.Add(i);
                    dem2 += 2;
                }
            }

            Console.WriteLine(dem);
            Console.WriteLine(dem2);
            return list;
        }

        public static void Main(String[] args)
        {
            int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            int index = MinValue(arr);
            Console.WriteLine("The smallest element in the array is: " + arr[index]);

            List<int> list = new List<int>() { 5, 4, 12, 7, 8, 1, 6, 9, 1 };
            List<int> index2 = MinValue2(list);
            Console.WriteLine(String.Join(", ", index2));
            Console.ReadKey();
        }
        
    }
}
