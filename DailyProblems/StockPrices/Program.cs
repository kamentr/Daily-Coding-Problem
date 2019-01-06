using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stock = Console.ReadLine().Split(' ').Select(int.Parse).ToList();      // 2 10 5 10 9 11 
            int maxProfit = 0;
            int bestBet = 0;
            while (stock.Count > 1)
            {
                int minValue = stock.Min();
                int index = stock.IndexOf(minValue);
                for (int i = index; i < stock.Count; i++)
                {

                    if (maxProfit < stock[i] - minValue)
                    {
                        maxProfit = stock[i] - minValue;
                        bestBet = minValue;
                    }
                    stock.Remove(minValue);
                }
            }
            if (bestBet == 0)
            {
                Console.WriteLine("You cant profit from this stock!");
            }
            else
            {
                Console.WriteLine(bestBet);
            }
        }
    }
}
