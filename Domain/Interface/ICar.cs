namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface ICar
    {
        public string MaxSpeed { get; set; }
        public string EngineType { get; set; }
        public int Doors { get; set; }

        string ToString();
    }
}
