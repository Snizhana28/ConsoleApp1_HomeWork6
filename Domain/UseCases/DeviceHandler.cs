using ConsoleApp1_HomeWork6.Domain.Interface;
using ConsoleApp1_HomeWork6.Domain.Models;

namespace ConsoleApp_HomeWork6.Domain.Usecases
{
    public class DeviceHandler : IOutput<Device>
    {
        public void ShowInfo(Device device)
        {
            Console.WriteLine("\n");
            device.Show();
            device.Desc();
            device.Sound();
        }
    }
}