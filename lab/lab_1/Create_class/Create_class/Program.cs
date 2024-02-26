using System;
class Employee
{
    public double salary;
    public string firstName, lastName;
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public Employee(int salary, string firstName,string lastName)
    {
        this.salary = salary;
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public void showdetail(string firstName, string lastName)
    {
        Console.WriteLine("Full Name is " + firstName +" "+ lastName);
    }
    public void Increment(double amount)
    {
        salary +=salary*amount/100;
    }
    public void ShowFullName()
    {
        Console.WriteLine("Full Name is "+ firstName+" "+lastName);
        Console.WriteLine("The salary is "+ salary);
       
    }
}
class Create_class
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(300,"Ram","Bahadur");
        emp.ShowFullName();
        emp.FirstName = "Hari";
        emp.Increment(10);
        Console.WriteLine("Updated Employee " );
        emp.ShowFullName();
        Console.ReadKey();
    }
}