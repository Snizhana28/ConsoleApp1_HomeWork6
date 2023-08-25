
using ConsoleApp1_HomeWork6.Domain.Interface;
using ConsoleApp1_HomeWork6.Domain.Models;

namespace ConsoleApp1_HomeWork6.Domain.UseCases
{
    public class InstrumentHandler : IOutput<Musicalinstrument>
    {
        public void ShowInfo(Musicalinstrument instrument)
        {
            Console.WriteLine("\n");
            instrument.ShowName();
            instrument.Desc();
            instrument.Hist();
            instrument.Sound();
        }
    }
}
