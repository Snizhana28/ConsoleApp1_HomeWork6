namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface IDevice
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        string ToString();
        void Show();
    }
}
