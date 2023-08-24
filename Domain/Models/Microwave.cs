using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Microwave : Device, IMicrowave
    {
        public string Volume { get; set; }
        public string Power { get; set; }
        public string Material { get; set; }
        public Microwave() { }
        public Microwave(string name, string model, string color, int year, string volume, string power, string material) : base(name, model, color, year)
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
            Console.WriteLine("Microwave sound: Beep beep");
        }
        public override void Desc()
        {
            Console.WriteLine("Model : " + Model + "\nColor : " + Color + "\nYear : " + Year + "\nVolume : " + Volume + "\nPower : " + Power + "\nMaterial : " + Material);
        }
    }
}
