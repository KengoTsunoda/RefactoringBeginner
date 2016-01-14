using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterRefactoring
{
    public class ShapeRectangle : Shape
    {
        protected ShapeRectangle(int startx, int starty, int endx, int endy)
        {
            
        }

        public override int Typecode()
        {
 	        return Shape.TYPECODE_RECTANGLE;
        }

        public override string GetName()
        {
            return "RECTANGLE";
        }

        public override void Draw()
        {
            DrawRectangle();
        }

        private void DrawRectangle()
        {
            Console.WriteLine("DrawRectngle");
        }
    }
}
