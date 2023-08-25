using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Musicalinstrument : IMusicalinstrument
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string History { get; set; }

        public Musicalinstrument() { }

        public Musicalinstrument(string name, string color, string material, string history)
        {
            Name = name;
            Color = color;
            Material = material;
            History = history;
        }
        public void ShowName()
        {
            Console.WriteLine($"Name: {Name}");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Default sound of a musical instrument");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Color: {Color}\nMaterial: {Material}");
        }
        public void Hist()
        {
           Console.WriteLine($"History: {History}");
        }      
        public override string ToString()
        {
            return $"Name: {Name}\nColor: {Color}\nMaterial: {Material}\nHistory: {History}";
        }
    }
}
