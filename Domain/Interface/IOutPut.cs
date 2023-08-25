using ConsoleApp1_HomeWork6.Domain.Interface;
using ConsoleApp1_HomeWork6.Domain.Models;
namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface IOutput<T>
    {
        public void ShowInfo(T instrument);
    }
}
