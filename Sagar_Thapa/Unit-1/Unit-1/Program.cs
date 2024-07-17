using System;

namespace DelegateExample
{
    public delegate void addnum(int a, int b);


    class SingleDelegata
    {
        public void sum(int a, int b)
        {

            Console.WriteLine(a + b);

        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            SingleDelegata obj = new SingleDelegata();
            addnum sum1= new addnum(obj.sum);

            sum1(10, 2);

        }
    }
}
 