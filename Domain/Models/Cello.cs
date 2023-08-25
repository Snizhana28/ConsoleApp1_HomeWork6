using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Cello : Musicalinstrument, ICello
    {
        public int Size { get; set; }
        public int Weight { get; set; }
        public Cello() { }
        public Cello(string name, string color, string material, string history, int size, int weight) : base(name, color, material, history)
        {
            Size = size;
            Weight = weight;
        }
        public override void Desc()
        {
            Console.WriteLine($"Color: {Color}\nMaterial: {Material}\nSize: {Size}\nWeight: {Weight}");
        }
        public override void Sound()
        {
            Console.WriteLine("Sound of a cello: rich and deep");
        }
        public override string ToString()
        {
            return $"Name: {Name}\nColor: {Color}\nMaterial: {Material}\nHistory: {History}\nSize: {Size}\nWeight: {Weight}";
        }

    }
}
