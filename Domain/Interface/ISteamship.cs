
namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface ISteamship
    {
        public string MaxSpeed { get; set; }
        public string EngineType { get; set; }
        public int NumberOfSeats { get; set; }

        string ToString();
    }
}
