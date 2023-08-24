using ConsoleApp1_HomeWork6.Domain.Interface;
using System.Drawing;
using System.Reflection;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Kettle : Device, IKettle
    {
        public string Volume { get; set; }
        public string Power { get; set; }
        public string Material { get; set; }

        public Kettle() { }
        public Kettle(string name, string model, string color, int year, string volume, string power, string material) : base(name, model, color, year)
        {
            Volume = volume;
            Power = power;
            Material = material;
        }
        public override string ToString()
        {
            return $"Volume: {Volume}, Power: {Power}, Material: {Material}";
        }
        public override void Sound()
        {
            Console.WriteLine("Kettle sound: Whistle");
        }
        public override void Desc()
        {
            Console.WriteLine("Model : " + Model + "\nColor : " + Color + "\nYear : " + Year + "\nVolume : " + Volume + "\nPower : " + Power + "\nMaterial : " + Material);
        }
    }
}
