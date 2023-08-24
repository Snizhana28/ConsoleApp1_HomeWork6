using ConsoleApp1_HomeWork6.Domain.Models;
using ConsoleApp1_HomeWork6.Domain.Usecases;

namespace ConsoleApp1_HomeWork6.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Money money= new Money(100, 50, new Currency("usd", "cent", "$"));
                Products product = new Products("Shake", money);
                ProductHandler.Show(product);
                ProductHandler.ReducePrice(50, 25, money);
                ProductHandler.Show(product);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}