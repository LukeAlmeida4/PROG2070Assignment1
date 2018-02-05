using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment1
{
    class Rectangle
    {
        private static int length;
        private static int width;

        public static int GetLength()
        {
            length = 1;
            return length;
        }

        public static int SetLength(int Length)
        {
            length = Length;
            if (length <= 0)
            {
                Console.WriteLine("Please enter a positive value");
                return GetLength();
            }
            else
            {
                return length;
            }
        }

        public static int GetWidth()
        {
            width = 1;
            return width;
        }

        public static int SetWidth(int Width)
        {
            width = Width;
            if (width <= 0)
            {
                Console.WriteLine("Please enter a poitive value");
                return GetWidth()   ;
            }
            else
            {
                return width;
            }
        }

        public static int GetPerimeter()
        {
            return (length + width) * 2;
        }

        public static int GetArea()
        {
            return length * width;
        }
    }
}
