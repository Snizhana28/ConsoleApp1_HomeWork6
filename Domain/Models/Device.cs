using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Device : IDevice
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Device() { }
        public Device(string name, string model, string color, int year)
        {
            Name = name;
            Model = model;
            Color = color;
            Year = year;
        }
        public void Show()
        {
            Console.WriteLine("Device: " + Name);
        }

        public virtual void Sound()
        {
            Console.WriteLine("Device sound");
        }

        public virtual void Desc()
        {
            Console.WriteLine("Model : " + Model + "\nColor : " + Color + "\nYear : " + Year);
        }
    }
}
