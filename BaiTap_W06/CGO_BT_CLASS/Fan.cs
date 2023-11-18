using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_TH01_CLASS
{
    public class Fan
    {
        public int SLOW = 1;
        public int MEDIUM = 2;
        public int FAST = 3;
        public string tocdo;
        public string bathaytat;
        private int speed { get; set; }
        private bool onoff { get; set; }
        private double radius = 5;
        private string colour {  get; set; }
        public Fan(int Speed, bool Onoff, string Colour, double Radius = 5)
        {
            this.speed = Speed;
            if (speed == 1){ tocdo = "slow";}
            if (speed == 2){ tocdo = "medium"; }
            if( speed== 3) { tocdo = "fast"; }
            this.onoff = Onoff;
            if (onoff==false)
            {
                bathaytat = " TAT";
            }
            else
            {
                bathaytat = "BAT";
            }
            this.colour = Colour;
            this.radius = Radius;
        }
        public void Display()
        {
            Console.WriteLine($"toc do cua cai quat {speed} rat la {tocdo} dang {bathaytat} co mau {colour} va ban kinh la {radius}");
        }
        public override string ToString()
        {
            return $"Speed: {speed}, Status: {bathaytat}, Color: {colour}, Radius: {radius}";
        }

    }
}
 