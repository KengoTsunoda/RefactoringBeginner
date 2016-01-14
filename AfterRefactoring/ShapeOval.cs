using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterRefactoring
{
    public class ShapeOval : Shape
    {
        protected ShapeOval(int startx, int starty, int endx, int endy)
        {

        }

        public override int Typecode()
        {
            return Shape.TYPECODE_OVAL;
        }

        public override string GetName()
        {
            return "OVAL";
        }

        public override void Draw()
        {
            DrawOval();
        }

        private void DrawOval()
        {
            Console.WriteLine("DrawOval");
        }
    }
}
