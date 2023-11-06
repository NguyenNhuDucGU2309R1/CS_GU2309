using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luot_dem=4;
            int vi_tri=0;
            int gia_tri=-1;
            List<int> list = new List<int>() { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };
            Console.WriteLine("\ncac phan tu cua list la");
            foreach(int item in list) 
            {
                Console.Write( item  + "  ");
            }
            Console.WriteLine("\ngia tri c ban muon them vao ");
            while(!int.TryParse(Console.ReadLine(), out gia_tri))
            {
                luot_dem--;
                Console.WriteLine("so ban nhap khong hop le");
                if(luot_dem == 0)
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
            list.Insert(vi_tri - 1, gia_tri);
            foreach( int i in list )
            {
                Console.Write(i + "  ");                
            }
            Console.ReadKey();
            


        } 
    }
}
