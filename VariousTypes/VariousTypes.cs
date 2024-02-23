using System;
using System.Text;

namespace VariousTypes
{
    class Program
    {
      
      static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 0x123;
            uint y = 0x245;
            char c1 = '\u2462';
            char c2 = '\u1823';
            float r1 = 1.14f;
            float r2 = 1.04f;
            bool b1 = false;
            bool b2 = true;
            string s1 = "Um tab\t e um copyright\u03A9";


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(s1);
        }
    }
}
