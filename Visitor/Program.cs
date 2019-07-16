using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);
            Console.WriteLine(vodka);

            Perfume perfume = new Perfume(10);

            ShopRent shopRent = new ShopRent(100);

            IVisitor endOfYearVisitor = new EndOfYearTax();
            IVisitor oneShekelSaleVisitor = new OneShekelSale();

            Console.WriteLine($"Price after liquor tax = {vodka.Accept(endOfYearVisitor)}");
            Console.WriteLine($"Price after prefume tax = {perfume.Accept(endOfYearVisitor)}");
            Console.WriteLine($"Price after rent tax = {shopRent.Accept(endOfYearVisitor)}");

            Console.WriteLine($"Price after liquor sale = {vodka.Accept(oneShekelSaleVisitor)}");
            Console.WriteLine($"Price after prefume sale = {perfume.Accept(oneShekelSaleVisitor)}");
            Console.WriteLine($"Price after rent sale = {shopRent.Accept(oneShekelSaleVisitor)}");
        }
    }
}
