using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Methodを呼び出す。
            Shape line = Shape.createShape(Shape.TYPECODE_LINE, 0, 0, 100, 200);
            Shape rectangle = Shape.createShape(Shape.TYPECODE_RECTANGLE, 10, 20, 30, 40);
            Shape oval = Shape.createShape(Shape.TYPECODE_OVAL, 100, 200, 300, 400);

            Shape[] shape = { line, rectangle, oval };

            foreach (Shape s in shape)
            {
                s.Draw();
            }
        }
    }
}
