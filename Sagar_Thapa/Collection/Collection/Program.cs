using System;
using System.Collections.Generic;

namespace Collection
{ 

    internal class Sagar
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(14);

            numbers.Add(12);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }

            numbers.Remove(1);
            numbers.Add(4);
            numbers.Add(33);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int search;
            Console.WriteLine("Enter the search number");
            search = int.Parse(Console.ReadLine());


            if (numbers.Contains(search))
            {
                Console.WriteLine("{0} is in the list", search);
            }
            else
            {
                Console.WriteLine($"{search} is not in the list");
            }


            Console.ReadKey();

        }
    }

}