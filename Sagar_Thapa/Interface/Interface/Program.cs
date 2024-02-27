using System;
namespace Interface
{

    public interface IAdm
    {
        void Manage();
    }

    public interface IT
    {
        void Code();
    }

    public class Admstaff : IAdm
    {
        public void Manage()
        {
            Console.WriteLine("Managing administrative tasks.");
        }
    }

    public class ITstaff : IT
    {
        public void Code()
        {
            Console.WriteLine("Write code ");
        }
    }
    internal class Sagar
    {
        static void Main(string[] args)
        {
            Admstaff adms = new Admstaff();
            ITstaff its = new ITstaff();

            Console.WriteLine("Administrative staff:");
            adms.Manage();


            Console.WriteLine("Technical staff:");
            its.Code();


            Console.ReadKey();

        }
    }
}