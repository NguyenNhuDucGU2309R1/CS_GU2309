using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_TEST_CLASS
{
    public class Shape

    {
        public int x { get; private set; }
        public int y {  get;private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("0");
        }
     }
    class Circle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
            base.Draw();

        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a Rectangle");
            base.Draw();
        }
    }
    class tritangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a triangle");
            base.Draw();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Circle(),
                new tritangle(),
            };
            foreach ( var  shape in shapes ) 
            {
                shape.Draw();
            } 
            Console.WriteLine(" press any key to exit");
            Console.ReadKey();
        }
    }


       




  

    }
    


