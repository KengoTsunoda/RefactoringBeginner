using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterRefactoring
{
    public class ShapeLine : Shape
    {
        protected ShapeLine(int startx, int starty, int endx, int endy)
        {
            
        }

        public override int Typecode()
        {
            return Shape.TYPECODE_LINE;
        }

        public override string GetName()
        {
            return "LINE";
        }

        public override void Draw()
        {
            DrawLine();
        }

        private void DrawLine()
        {
            Console.WriteLine("DrawLine");
        }
    }
}
