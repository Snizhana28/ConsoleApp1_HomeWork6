using ConsoleApp_HomeWork6.Domain.Usecases;
using ConsoleApp1_HomeWork6.Domain.Models;

namespace ConsoleApp1_HomeWork6.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle("Electro kettle", "Samsung", "Gray", 2020, "1l", "2.5 kW", "metal");
            Microwave microwave = new Microwave("Microwave", "Philips", "White", 2021, "20l", "300W", "metal");
            Car car = new Car("Toyota", "Camry", "Black", 2022, "210 km/h", "Gasoline", 4);
            Steamship steamship = new Steamship("Passenger Steamship", "NoName", "Green", 2023, "110 km/h", "Steam", 5000);

            DeviceHandler deviceHandler = new DeviceHandler();
            deviceHandler.ShowInfo(kettle);
            deviceHandler.ShowInfo(microwave);
            deviceHandler.ShowInfo(car);
            deviceHandler.ShowInfo(steamship);
        }
    }
}