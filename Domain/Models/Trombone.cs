using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Trombone : Musicalinstrument, ITrombone
    {
        public string KindofTrombone { get; set; }
        public int LengthPipe { get; set; }

        public Trombone() { }
        public Trombone(string name, string color, string material, string history, string kindofTrombone, int lengthPipe) : base(name, color, material, history)
        {
            KindofTrombone = kindofTrombone;
            LengthPipe = lengthPipe;
        }
        public override void Desc()
        {
            Console.WriteLine($"Color: {Color}\nMaterial: {Material}\nKind of trombone: {KindofTrombone}\nLength of pipe: {LengthPipe}");
        }
        public override void Sound()
        {
            Console.WriteLine("Sound of a trombone: brassy");
        }
        public override string ToString()
        {
            return $"Name: {Name}\nColor: {Color}\nMaterial: {Material}\nHistory: {History}\nKind of trombone: {KindofTrombone}\nLength of pipe: {LengthPipe}";
        }
    }
}
