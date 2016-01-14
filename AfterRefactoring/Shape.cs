using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AfterRefactoring
{
    public abstract class Shape
    {
        public const int TYPECODE_LINE = 0;
        public const int TYPECODE_RECTANGLE = 1;
        public const int TYPECODE_OVAL = 2;

        private int _startx;
        private int _starty;
        private int _endx;
        private int _endy;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Shape(int startx, int starty, int endx, int endy)
        {
            _startx = startx;
            _starty = starty;
            _endx = endx;
            _endy = endy;
        }

        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="typecode"></param>
        /// <param name="startx"></param>
        /// <param name="starty"></param>
        /// <param name="endx"></param>
        /// <param name="endy"></param>
        /// <returns></returns>
        public static Shape createShape(int typecode, int startx, int starty, int endx, int endy)
        {
            switch(typecode)
            {
                case TYPECODE_LINE:
                    return new ShapeLine(startx, starty, endx, endy);
                case TYPECODE_RECTANGLE:
                    return new ShapeRectangle(startx, starty, endx, endy);
                case TYPECODE_OVAL:
                    return new ShapeOval(startx, starty, endx, endy);
                default:
                    throw new ArgumentException("typecode = " + typecode);
            }
        }

        public abstract int Typecode();

        public abstract string GetName();

        public abstract void Draw();
    }
}