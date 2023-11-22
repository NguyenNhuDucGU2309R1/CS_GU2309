using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG0_TH03
{
    public class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.getRadius() > c2.getRadius()) return 1;
            else if (c1.getRadius() < c2.getRadius()) return -1;
            else return 0;
        }
    }
}
