using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Car : Device, ICar
    {
        public string MaxSpeed { get; set; }
        public string EngineType { get; set; }
        public int Doors { get; set; }
        public Car() { }
        public Car(string name, string model, string color, int year, string maxSpeed, string engineType, int doors) : base(name, model, color, year)
        {
            MaxSpeed = maxSpeed;
            EngineType = engineType;
            Doors = doors;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Color: {Color}";
        }
        public override void Sound()
        {
            Console.WriteLine("Car sound: Vroom vroom");
        }
        public override void Desc()
        {
            Console.WriteLine("Model : " + Model + "\nColor : " + Color + "\nYear : " + Year + "\nMax speed : " + MaxSpeed + "\nEngine type : " + EngineType + "\nDoors : " + Doors);
        }
    }
}
