using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Money : Currency, IMoney
    {
        public decimal WholePartValue { get; set; }
        public decimal FractionalPartValue { get; set; }
        public ICurrency Currency { get; set; }
        public Money() { }
        public Money(decimal wholePartValue, decimal fractionalPartValue, ICurrency currency)
        {
            WholePartValue = wholePartValue;
            FractionalPartValue = fractionalPartValue;
            Currency = currency;
        }
        public override string ToString()
        {
            return $"{WholePartValue} {Currency.NameWholePart} {FractionalPartValue} {Currency.NameWholePart}";
        }
    }
}
