using System;
    namespace lab_1
{
    internal class Program {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine("hello world");
            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}",i,arr[i]);
            }


            Console.ReadKey();
        }
    }

}



