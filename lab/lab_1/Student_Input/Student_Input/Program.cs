using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "student_info.txt";

        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("John Doe, 20, A");
            writer.WriteLine("Jane Smith, 21, B"); 
        }

        Console.WriteLine("Student info has been written to the file.");
        Console.WriteLine("\nStudent info read from the file:");
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        Console.ReadKey();
    }
}
