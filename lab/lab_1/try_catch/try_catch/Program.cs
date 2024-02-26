using System;
class try_catch
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10, b = 0,divide;
            divide = a / b;
            

        }
        catch (DivideByZeroException e1)
        {
            Console.WriteLine(e1.ToString());
            Console.ReadKey();

        }
    }
}