using ConsoleApp1_HomeWork6.Domain.Interface;
using ConsoleApp1_HomeWork6.Domain.Models;

namespace ConsoleApp1_HomeWork6.Domain.Usecases
{
    public class ProductHandler 
    {
        public static void Show(Products product) 
        {
            Console.WriteLine(product.ToString());
        }
        public static void ReducePrice(decimal value1, decimal value2, Money money)
        {
            if (value1 > money.WholePartValue)
            {
                throw new ArgumentException("The value connot be more than the price of the product.");
            }
            else
            {
                money.WholePartValue -= value1;
                money.FractionalPartValue -= value2;
            }
        }
    }
}
