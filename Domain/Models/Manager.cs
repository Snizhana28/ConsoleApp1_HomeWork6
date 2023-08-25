namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Manager : Worker
    {
        public Manager(string name, string position) : base(name, position) { }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}\n Position: {Position}\nResponsibilities: Team management and coordination");
        }
    }
}
