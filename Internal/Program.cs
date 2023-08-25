using ConsoleApp1_HomeWork6.Domain.Models;

namespace ConsoleApp1_HomeWork6.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[4];
            workers[0] = new President("Vladimir", "President");
            workers[1] = new Security("Ivan", "Security");
            workers[2] = new Manager("Petro", "Manager");
            workers[3] = new Engineer("Oleg", "Engineer");
            foreach (Worker worker in workers)
            {
                worker.Print();
                Console.WriteLine();
            }
        }
    }
}