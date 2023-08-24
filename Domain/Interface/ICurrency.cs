namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface ICurrency
    {
        public string NameWholePart { get; set; }
        public string NameFractionalPart { get; set; }
        public string Symbol { get; set; }
        string ToString();
    }
}
