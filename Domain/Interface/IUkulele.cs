namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface IUkulele
    {
        public int NumberOfStrings { get; set; }
        public int NumberOfFrets { get; set; }
        string ToString();
    }
}
