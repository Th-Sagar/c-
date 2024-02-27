using System;
namespace try_catch
{
    internal class Sagar
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10, b = 0, divide;
                divide = a / b;


            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine(e1.ToString());
                Console.ReadKey();

            }
        }
    }
}