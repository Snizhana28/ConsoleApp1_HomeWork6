using ConsoleApp1_HomeWork6.Domain.Models;
using ConsoleApp1_HomeWork6.Domain.Usecases;

namespace ConsoleApp1_HomeWork6.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Запрограмуйте клас Money (об'єкт класу оперує однією 
            валютою) для роботи з грошима.
            У класі мають бути передбачені: поле для зберігання 
            цілої частини грошей (долари, євро, гривні тощо) і поле 
            для зберігання копійок (центи, євроценти, копійки тощо)
            Реалізувати методи виведення суми на екран, задання 
            значень частин. 
            На базі класу Money створити клас Product для роботи 
            з продуктом або товаром. Реалізувати метод, який дозволяє 
            зменшити ціну на задане число.
            Для кожного з класів реалізувати необхідні методи і 
            поля.*/
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