using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Steamship : Device, ISteamship
    {
        public string MaxSpeed { get; set; }
        public string EngineType { get; set; }
        public int NumberOfSeats { get; set; }
        public Steamship() { }
        public Steamship(string name, string model, string color, int year, string maxSpeed, string engineType, int numberOfSeats) : base(name, model, color, year)
        {
            MaxSpeed = maxSpeed;
            EngineType = engineType;
            NumberOfSeats = numberOfSeats;
        }
        public override string ToString()
        {
            return $"MaxSpeed: {MaxSpeed}, EngineType: {EngineType}, NumberOfSeats: {NumberOfSeats}";
        }
        public override void Sound()
        {
            Console.WriteLine("Steamship sound: Choo choo");
        }
        public override void Desc()
        {
            Console.WriteLine("Model : " + Model + "\nColor : " + Color + "\nYear : " + Year + "\nMax speed : " + MaxSpeed + "\nEngine type : " + EngineType + "\nNumber of seats : " + NumberOfSeats);
        }
    }
}
