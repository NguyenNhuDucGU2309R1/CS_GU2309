using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_BT_W06_KETHUA
{
    class Point3D : Point2D
    {
        private double z;

        public Point3D(double x, double y, double z = 0.0) : base(x, y)
        {
            this.z = z;
        }
        public double Z { get => z; set => z = value; }
        public void SetXYZ(double x, double y, double z = 0.0)
        {
            base.SetXY(x, y);
            this.z = z;
        }
        public List<double> GetXYZ()
        {
            List<double> result = new List<double>();
            result = base.GetXY();
            result.Add(z);

            return result;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, this.z);
        }
    }
}
