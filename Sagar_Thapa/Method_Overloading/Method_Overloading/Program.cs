using System;
namespace Method_Overloading
{

    internal class Sagar
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            string s = "ram", t = "shyam ";
            Console.WriteLine("The sum of {0} and {1} is {2} ", a, b, Min(a, b));
            Console.WriteLine("The sum of {0} and {1} is {2} ", s, t, Min(s, t));

            Console.ReadKey();

        }

        static int Min(int x, int y)
        {
            return (x + y);
        }
        static string Min(string x, string y)
        {
            return (x + y);
        }
    }
}