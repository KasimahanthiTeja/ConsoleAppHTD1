using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHTD1
{
    internal class Datatypes
    {
        static void main()
        {
            byte x = 255;
            byte y = 100;
            byte z = 150;
            byte x1 = 0;
            sbyte x2 = -100;
            Console.WriteLine((byte)x);
            Console.WriteLine((byte)y);
            Console.WriteLine((byte)z);
            Console.WriteLine((sbyte)x1);

            double d1 = 454.14;
            double d2 = 400.34;
            Console.WriteLine((double)d1);
            Console.WriteLine((double)d2);

            decimal d3 = 88.5m;
            decimal d4 = 77.6m;
            Console.WriteLine((decimal)d3);
            Console.WriteLine((decimal)d4);

            float f1 = 28.5f;
            float f2 = 54.5f;
            Console.WriteLine((float)f1);
            Console.WriteLine((float)f2);

            char c1 = 'A';
            char c2 = 'S';
            Console.WriteLine((char)c1);
            Console.WriteLine((char)c2);

            bool b1 = true;
            bool b2 = false;
            Console.WriteLine((bool)b1);
            Console.WriteLine((bool)b2);

            string str = "Hi Hello";
            string s2 = "Welcome back";
            Console.WriteLine((string)str);
            Console.WriteLine((string)s2);
        }
    }
}
