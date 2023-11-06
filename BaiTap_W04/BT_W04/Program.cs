using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BT_W04
{
    internal class Program
    { //THUC HANH 01
        static void THUCHANH01(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine(total.ToString());
            Console.ReadKey();
        }
        static void THUCHANH02(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
                Console.ReadKey();
            }
        }
        static void THUCHANH03(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);
            Console.ReadKey();

        }
        static void BAI_TAP01(string[] args)
        {
            int luot_dem = 4;
            int vi_tri = 0;
            int gia_tri = -1;
            List<int> list = new List<int>() { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };
            Console.WriteLine("\ncac phan tu cua list la");
            foreach (int item in list)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\ngia tri c ban muon them vao ");
            while (!int.TryParse(Console.ReadLine(), out gia_tri))
            {
                luot_dem--;
                Console.WriteLine("so ban nhap khong hop le");
                if (luot_dem == 0)
                {
                    Console.WriteLine("nhap qua so lan quy dinh");
                    Console.ReadKey();
                    return;
                }

            }
            Console.WriteLine("vi tri ban muon them vao");
            while (!int.TryParse(Console.ReadLine(), out vi_tri) || vi_tri > 10)

            {
                luot_dem--;
                Console.WriteLine("nhap so khong hop le ");
                if (luot_dem == 0)
                {
                    Console.WriteLine("ban nhap qua so lan ");
                    Console.ReadKey();
                    return;
                }

            }

            Console.WriteLine("cac phan tu cua list cua khi dc them vao");
            list.Insert(vi_tri = 1, gia_tri);
            foreach (int i in list)
            {
                Console.Write(i + "  ");
            }
            Console.ReadKey();
        }
        static void BAI_TAP02(string[] args)

        {

            Random rd = new Random();

            Console.Write("Enter array now:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter array col:");
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];
            var max = -1;

            #region cấp phát số ngẫu nhiên cho không trung lập
            Console.Write("\n elements of array: \n");

            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                while (j < m)
                    max = a[i, j];
                int item = rd.Next(10, 100);
                foreach (int temp in a)
                {
                    if (temp == item)
                        item = rd.Next(10, 100);

                }
                a[i, j] = item;
                Console.Write(a[i, j] + " "); j++;
            }
            foreach (int temp in a)
            {
                if (temp > max)
                    max = temp;
            }
            Console.WriteLine("\nmax number until now:" + max + "\n");
            #endregion
            #region xuát số lớn nhất cuả mảng và vị trí của nó 
            Console.Write("max number of array :" + max);

            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int elm = r * c;
            for (int pos = 0; pos < elm; pos++)
            {
                int iM = pos / c;
                int jM = pos % c;
                if (a[iM, jM] == max)
                    Console.Write(" at possotion a[{0}],row:{2},colum:{3}", iM, jM, (iM + 1), (jM + 1));
            }
            #endregion
            #region nhập mới giá trị của lần lượt các phần tử của mảng
            Console.WriteLine("\n\nEnter new value for array");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                while (j < m)
                {
                    Console.Write(" element - [{0},{1}]:", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine()); j++;
                }

            }
            #endregion
            #region xuất mảng mới 
            Console.Write("\nElements of array:\n");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                Console.Write("\n");
                while (j < m)
                {
                    Console.Write("{0}\t", a[i, j]);
                    j++;

                }
            }
            #endregion

        }
        static void BAI_TAP03()
        {
            Console.WriteLine("size of input:"); //b1: khoi tao size (row = col)
            int size = int.Parse(Console.ReadLine());

            List<List<int>> twoDList = new List<List<int>>();//b2: khoi tao 2D list

            //b3: khoi tao list GAN GIONG array 2D, tao i la hang, va tao j la cot
            for (int i = 0; i < size; i++)
            {
                List<int> row = new List<int>(); //voi List, phai tao them list de them cac phan tu vao hang
                for (int j = 0; j < size; j++)   //them cac phan tu vao hang
                {
                    //chung ta can them phan tu vao list
                    Console.WriteLine("Input your value");
                    int value = int.Parse(Console.ReadLine());
                    //neu la array, thi se la myArray[i,j] = value , nhung day la list, cho nen ta can phai viet:
                    row.Add(value); //them tung phan tu vao hang (row)                
                }
                twoDList.Add(row);//them tung hang vao bang
            }

            //bay gio in ra
            //GIONG nhu thang array
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(twoDList[i][j] + " ");
                }
                Console.WriteLine(" ");
            }

            //bay gio in ket qua
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write(twoDList[i][j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
        static void THUCHANH04()
        {
            string[,] map = {
     {"*", ".", ".", "."},
      {".", ".", ".", "."},
      {".", "*", ".", "."},
      {".", ".", ".", "."}
                            };

            int MAP_HEIGHT = map.GetLength(0);
            int MAP_WIDTH = map.GetLength(1);
            string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                for (int xOrdinate = 0; xOrdinate < map.GetLength(0); xOrdinate++)
                {
                    string curentCell = map[yOrdinate, xOrdinate];
                    if (curentCell.Equals("*"))
                    {
                        mapReport[yOrdinate, xOrdinate] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = {
                        {yOrdinate - 1, xOrdinate - 1}, {yOrdinate - 1, xOrdinate}, {yOrdinate - 1, xOrdinate + 1},
                        {yOrdinate, xOrdinate - 1}, {yOrdinate, xOrdinate + 1},
                        {yOrdinate + 1, xOrdinate - 1}, {yOrdinate + 1, xOrdinate}, {yOrdinate + 1, xOrdinate + 1},};

                        int minesAround = 0;
                        int length = NEIGHBOURS_ORDINATE.GetLength(0);
                        for (int i = 0; i < length; i++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                    || xOrdinateOfNeighbour == MAP_WIDTH
                                    || yOrdinateOfNeighbour < 0
                                    || yOrdinateOfNeighbour == MAP_HEIGHT;
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }
                            bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesAround++;
                            }
                        }
                        mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
                    }
                }
            }
            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                Console.WriteLine("\n");
                for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                {
                    String currentCellReport = mapReport[yOrdinate, xOrdinate];
                    Console.Write(currentCellReport);
                }
            }
            Console.ReadKey();
        }
        








static void Main(string[] args)
        {
            THUCHANH04();
            Console.ReadKey();
        }

    }
}

    

