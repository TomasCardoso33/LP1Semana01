using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tells the user what he should do
            Console.WriteLine("Enter an int number:");

            // Create a string variable and get the int number
            string s1 = Console.ReadLine();
            //Converts the string into an int
            int i1 = int.Parse(s1);

            Console.WriteLine("Enter a float number");
            string s2 = Console.ReadLine();
            //Converts the string into a float
            float f1 =float.Parse(s2);
            //Adds the float to the int
            float r1 = f1 + i1;
            //Writes the answer
            Console.WriteLine(i1+"+"+f1+"="+r1);




            
        }
    }
}
