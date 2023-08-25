using ConsoleApp1_HomeWork6.Domain.Interface;
using ConsoleApp1_HomeWork6.Domain.Models;
using ConsoleApp1_HomeWork6.Domain.UseCases;
namespace ConsoleApp1_HomeWork6.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InstrumentHandler instrument = new InstrumentHandler();

            Cello cello = new Cello("Cello", "Brown", "Wood", "Cello is a bowed string instrument with four strings tuned in perfect fifths. It is a member of the violin family of musical instruments, which also includes the violin, viola and double bass.", 4, 5);
            Trombone trombone = new Trombone("Trombone", "Gold", "Brass", "The trombone is a musical instrument in the brass family. As on all brass instruments, sound is produced when the player's vibrating lips (embouchure) cause the air column inside the instrument to vibrate.", "-", 3);
            Ukulele ukulele = new Ukulele("Ukulele", "Brown", "Wood", "The ukulele is a member of the lute family of instruments. It generally employs four nylon strings.", 4, 4);
            Violin violin = new Violin("Violin", "Brown", "Wood", "The violin, sometimes known as a fiddle, is a wooden chordophone (string instrument) in the violin family. Most violins have a hollow wooden body. It is the smallest and highest-pitched instrument in the family in regular use.", 4, 4);

            instrument.ShowInfo(cello);
            instrument.ShowInfo(trombone);
            instrument.ShowInfo(ukulele);
            instrument.ShowInfo(violin);
        }
    }
}