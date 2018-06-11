using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingCoinChange
{
    //Given an input x, write a function to determine the minimum number of 
    //coins required to make that exact amount of change
    //American Coins    1,5,10,25
    /*                  x = 1 -> 1
                        x = 2 -> 2
                        x = 5 -> 1
    */
    class ChangeApp
    {
        static void Main(string[] args)
        {
            int[] coinsArr = {25,10,5,1};
            ChangeApp coinApp = new ChangeApp();
            int numberOfCoins = coinApp.CoinsChange(32,coinsArr);
            Console.WriteLine($"The total number of coins is: {numberOfCoins}");
            int numCoins = coinApp.Change(2, coinsArr);
            Console.WriteLine($"The total number of coins using DP is: {numCoins}");
            Console.ReadKey();

        }

        public int CoinsChange(int givenCoin, int[] availableCoins)
        {
            if(givenCoin == 0)
            {
                return 0;
            }
            int min = givenCoin;
            foreach (int coin in availableCoins)
            {
                if (givenCoin-coin >= 0)
                {
                    int c = CoinsChange(givenCoin-coin, availableCoins);
                    if (min > c+1)
                    {
                        min = c + 1;
                    }
                }
            }
            return min;
        }
        //using Dynamic Programming
        public int Change(int x, int[] coins)
        {
            int[] cache = new int[x];
            for (int i = 1; i<x; i++)
            {
                cache[i] = -1;
            }
            return Change(x, coins, cache);
        }
        public int Change(int x, int[] coins, int[] cache)
        {
            if (x == 0)
            {
                return 0;
            }
            int min = x;
            foreach (int coin in coins)
            {
                if (x - coin >= 0)
                {
                    int c;
                    if (cache[x - coin] >= 0)
                    {
                        c = cache[x - coin];
                    }
                    else
                    {
                        c = Change(x - coin, coins, cache);
                        cache[x - coin] = c;
                    }
                    if (min > c + 1)
                    {
                        min = c + 1;
                    }
                }
            }
            return min;
        }
    }
}
