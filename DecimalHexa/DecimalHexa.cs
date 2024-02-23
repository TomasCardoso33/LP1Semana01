using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 4 int numbers:");
            
            string s1 = Console.ReadLine();
            int i1 = int.Parse(s1);
            

            string s2 = Console.ReadLine();
            int i2 = int.Parse(s2);

            string s3 = Console.ReadLine();
            int i3 = int.Parse(s3);

            string s4 = Console.ReadLine();
            int i4 = int.Parse(s4);

            Console.WriteLine($"{i1,6:d}    {i1,6:X}");
            Console.WriteLine($"{i2,6:d}    {i2,6:X}");
            Console.WriteLine($"{i3,6:d}    {i3,6:X}");
            Console.WriteLine($"{i4,6:d}    {i4,6:X}");

        }
    }
}
