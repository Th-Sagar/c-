using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public string firstname;
    public string lastname;
    public int salary;

    public Employee() { }

    public Employee(string firstname, string lastname, int salary) {

        this.firstname = firstname;
        this.lastname = lastname;
        this.salary = salary;
    
    }

    public void Show()
    {
        Console.WriteLine("Frist Name :" + firstname);
        Console.WriteLine("Last Name :" + lastname);
        Console.WriteLine("Salary :" +  salary);
    }
    public void IncrementSalary()
    {
        this.salary = this.salary + 5000;
    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee point = new Employee();
            point.firstname = "Ram";
            point.lastname = "Bahadur";
            point.salary = 20000;
            point.Show();
            point.IncrementSalary();
            point.firstname = "Hari";
            point.Show();
            Console.ReadKey();

        }
    }
}
