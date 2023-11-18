using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_BT_W06_KETHUA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BT01
            Circle circle = new Circle(6, "Blue");
            Cylinder cylinder = new Cylinder(10, "Red", 8);

            Console.WriteLine(circle);
            Console.WriteLine(cylinder);
            Console.WriteLine(cylinder.TheTich());
            #endregion
            #region BT02
            Point2D point2D = new Point2D(2, 3.2);
            Console.WriteLine(point2D.ToString());

            Point3D point3D = new Point3D(2, 3.2, 3);
            Console.WriteLine(point3D.ToString());
            Console.WriteLine(string.Join(" ", point3D.GetXYZ()));
            #endregion



            Console.ReadKey();
        }
    }
}
