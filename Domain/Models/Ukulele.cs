using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Ukulele : Musicalinstrument, IUkulele
    {
        public int NumberOfStrings { get; set; }
        public int NumberOfFrets { get; set; }
        public Ukulele() { }
        public Ukulele(string name, string color, string material, string history, int numberOfStrings, int numberOfFrets) : base(name, color, material, history)
        {
            NumberOfStrings = numberOfStrings;
            NumberOfFrets = numberOfFrets;
        }
        public override void Desc()
        {
            Console.WriteLine($"Color: {Color}\nMaterial: {Material}\nNumber of strings: {NumberOfStrings}\nNumber of frets: {NumberOfFrets}");
        }
        public override void Sound()
        {
            Console.WriteLine("Sound of an ukulele: cheerful strumming");
        }
        public override string ToString()
        {
            return $"Name: {Name}\nColor: {Color}\nMaterial: {Material}\nHistory: {History}\nNumber of strings: {NumberOfStrings}\nNumber of frets: {NumberOfFrets}";
        }
    }
}
