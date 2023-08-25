using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public abstract class Worker : IWorker
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Worker(string name, string position)
        {
            Name = name;
            Position = position;
        }
        public abstract void Print();
    }
}
