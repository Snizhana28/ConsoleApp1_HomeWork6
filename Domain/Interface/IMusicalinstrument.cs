namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface IMusicalinstrument
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string History { get; set; }

        public void ShowName();
        public void Hist();
        string ToString();
    }
}
