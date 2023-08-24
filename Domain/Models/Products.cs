using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Products : IProducts
    {
        public string Name { get; set; }
        public Money Money { get; set; }
        public Products(string name, Money money)
        {
            Name = name;
            Money = money;
        }
        public override string ToString()
        {
            return $"{Name} {Money}";
        }
    }
}
