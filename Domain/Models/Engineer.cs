namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Engineer : Worker
    {
        public Engineer(string name, string position) : base(name, position) { }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}\n Position: {Position}\nResponsibilities: Technical design and development of new products");
        }
    }
}
