using System.Runtime.CompilerServices;

namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface IMoney
    {
        public decimal WholePartValue { get; set; }
        public decimal FractionalPartValue { get; set; }
        public ICurrency Currency { get; set; }
        string ToString();
    }
}
