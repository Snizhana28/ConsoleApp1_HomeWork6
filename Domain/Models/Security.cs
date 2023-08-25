namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Security : Worker
    {
        public Security(string name, string position) : base(name, position) { }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}\n Position: {Position}\nResponsibilities: Ensuring security and safety");
        }
    }
}
