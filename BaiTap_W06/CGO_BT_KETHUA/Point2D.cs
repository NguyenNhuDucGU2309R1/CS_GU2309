using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_BT_W06_KETHUA
{
    internal class Point2D
    {
        private double x, y;

        public Point2D(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public void SetXY(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public List<double> GetXY()
        {
            List<double> result = new List<double>();
            result.Add(this.x);
            result.Add(this.y);

            return result;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", x, y);
        }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }
}
