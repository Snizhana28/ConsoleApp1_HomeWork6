using ConsoleApp1_HomeWork6.Domain.Interface;

namespace ConsoleApp1_HomeWork6.Domain.Models
{
    public class Currency : ICurrency
    {
        public string NameWholePart { get; set; }
        public string NameFractionalPart { get; set; }
        public string Symbol { get; set; }
        public Currency() { }
        public Currency(string nameWholePart, string nameFractionalPart, string symbol)
        {
            NameWholePart = nameWholePart;
            NameFractionalPart = nameFractionalPart;
            Symbol = symbol;
        }
        public override string ToString()
        {
            return $"{NameWholePart} {NameFractionalPart} {Symbol}";
        }
    }
}
