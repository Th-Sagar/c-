using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_lab_1
{
    internal class SecondProgram
    {
        public static void Main(String[] agrs)
        {
            Console.WriteLine("Hello world second program");
            Student std = new Student(1, 1001, "ram", "ktm");
            std.displayStudent();
            Console.WriteLine("\n");
            Student std1 = new Student(2, 10002, "hari", "ktm");
            std1.displayStudent();

            int id, rollno;
            string address, name;
            Console.WriteLine("Enter your id");
           id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your roll");
           rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            address = Console.ReadLine();
            Student std3 = new Student(id, rollno, name, address);
            std3.displayStudent();

            Student std4 = new Student();
            std4.displayStudent(id,rollno,name,address);



        }
    }
}
