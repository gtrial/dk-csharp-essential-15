using System;
using System.Linq;

namespace task03
{
    internal static class Program
    {
        private static void Main()
        {
            var prices = new Price[] { };
            for (var i = 0; i < 2; i++)
            {
                var price = new Price();
                Console.WriteLine("Price {0}:", i + 1);
                Console.WriteLine("Product name: ");
                price.ProductName = Console.ReadLine();
                Console.WriteLine("Shop name: ");
                price.ShopName = Console.ReadLine();
                try
                {
                    Console.WriteLine("Product price: ");
                    price.ProductPrice = Double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                Array.Resize(ref prices, prices.Length + 1);
                prices[^1] = price;
            }

            prices = prices.OrderBy(i => i.ShopName).ToArray();

            Console.WriteLine("Search by shop name:");
            var searchShopName = Console.ReadLine();
            var shopCounter = 0;
            foreach (var item in prices)
            {
                if (item.ShopName == searchShopName)
                {
                    shopCounter++;
                    Console.WriteLine("{0}:{1}", item.ProductName, item.ProductPrice);
                }
            }

            if (shopCounter == 0)
            {
                throw new Exception("Shop or price where not found");
            }
        }
    }
}