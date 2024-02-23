using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Trinta e três \u2462\u2462";
            string s2 = "Ponto de exclamação \u1944";
            string s3 = "Hora de concatenar";
            string s4 = "O que estou eu a fazer?";
            string s5 = " A concatenar!";
            double xx = 1.23456;
            int ii = 19;
            string s6 = $".{xx:f2}. e .{String.Format("{0:p}", xx)}";
            string s7 = $".{String.Format("{0:c}", ii)}. e .{String.Format("{0:x}", ii)}";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3+"!!!");
            Console.WriteLine(s4+s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

        }
    }
}
