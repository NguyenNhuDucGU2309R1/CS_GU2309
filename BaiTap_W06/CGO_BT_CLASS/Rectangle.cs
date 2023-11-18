using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_BT_W06_CLASS
{
    public class Rectangle  
    {
            double width, height;

            public Rectangle()
            {
            }

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public double GetArea()
            {
                return this.width * this.height;
            }

            public double GetPerimeter()
            {
                return (this.width + this.height) * 2;
            }

            public string Display()
            {
                return "Rectangle{" + "width=" + width + ", height=" + height + "}";

            }
        }

}
