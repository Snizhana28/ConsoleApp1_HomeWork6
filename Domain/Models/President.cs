namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class President : Worker
    {
        public President(string name, string position) : base(name, position) { }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}\n Position: {Position}\nResponsibilities: Strategic decision making");
        }
    }
}
