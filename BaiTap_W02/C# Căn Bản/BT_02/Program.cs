using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float usd;
            float vnd = 23000 ;
            Console.Write("Nhap so tien USD muon quy doi: ");
            usd = float.Parse(Console.ReadLine());
            Console.Write("So tien VND: ");
            float  area = usd * vnd;
            Console.WriteLine(vnd=area);
            Console.WriteLine(vnd);
            Console.ReadKey();
                    
            

             
                
         

        }
    }
}
