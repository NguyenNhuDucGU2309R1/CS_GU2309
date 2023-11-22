using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_02
{
    class Robot : Player
    {
        List<int> choose = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public Robot(char sign = 'O') : base(sign)
        {

        }
        public int takeTurn()
        {

            Random rd = new Random();
            int index = rd.Next(0,choose.Count-1); // lua chon vi tri index tu 0 -> n-1
            return choose[index];
        }
        public void removeChoose(int value)
        {
            choose.Remove(value); // loai bo cac gia tri value da dc su dung
        }
    }
}





