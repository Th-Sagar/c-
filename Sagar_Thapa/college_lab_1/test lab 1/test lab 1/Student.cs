using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_lab_1
{
    public class Student
    {
        int id, roll;
         String name, address;

        public Student(int id, int roll, string name , string address)
        {
            this.id = id;
            this.roll = roll;
            this.name = name;
            this.address = address;
        }

        public Student() { }

        public void displayStudent()
        {
            Console.WriteLine("ID =" + id);
            Console.WriteLine("Roll =" + roll);
            Console.WriteLine("Name =" + name);
            Console.WriteLine("Address =" + address);

        }

        public void displayStudent(int id, int roll, string name, string address)
        {
            Console.WriteLine("ID =" + id);
            Console.WriteLine("Roll =" + roll);
            Console.WriteLine("Name =" + name);
            Console.WriteLine("Address =" + address);

        }
    }
}
