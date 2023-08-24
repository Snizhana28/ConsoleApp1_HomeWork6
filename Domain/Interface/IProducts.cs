using ConsoleApp1_HomeWork6.Domain.Models;

namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface IProducts
    {
        public string Name { get; set; }
        public Money Money { get; set; }
        string ToString();
    }
}
