//
// Solution.cs
//
// Author:
//       Ehouarn Perret <ehouarn.perret@outlook.com>
//
// Copyright (c) 2016 Ehouarn Perret
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.DynamicProgramming.Challenge3TheCoinChange
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var valueCoinCountString = @"10 4"; //Console.ReadLine();
            var valueCoinCountStringTokens = valueCoinCountString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var value = Convert.ToInt32(valueCoinCountStringTokens[0]);
            var coinCount = Convert.ToInt32(valueCoinCountStringTokens[1]);

            var coinsString = @"2 5 3 6"; //Console.ReadLine();
            var coinsStringTokens = coinsString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var coins = Array.ConvertAll(coinsStringTokens, Convert.ToInt32);

            if (coins.Length != coinCount)
            {
                throw new ArgumentOutOfRangeException(nameof(coins));
            }
            else
            {
                Console.WriteLine(Solution.CountCoinChanges(value, coins.Length,  coins));
            }
        }

        public static UInt32 CountCoinChanges(Int32 value, Int32 coinCount, IList<Int32> coins)
        {
            // Terminal conditions
            // Value is zero then... we dot not need any coin
            if (value == 0)
            {
                var stringBuilder = new StringBuilder();

                for (var i = 0; i < coinCount; i++)
                {
                    stringBuilder.Append(coins[i]);
                }

                return 1;
            }
            // Value is less than 0... then no solution
            else if (value < 0)
            {
                return 0;
            }
            // No more coins and value is positive so no solutions
            else if (coinCount <= 0)
            {
                return 0;
            }
            else
            {
                // Containing the cointCount - 1 coin and not containing the cointCount -1 coin
                return Solution.CountCoinChanges(value, coinCount - 1, coins) + Solution.CountCoinChanges(value - coins[coinCount - 1], coinCount, coins);
            }
        }
    }

    public struct CountCoin
    {
        public CountCoin(Int32 value, Int32 amount)
        {
            this.Value = value;
            this.Amount = amount;
        }

        public Int32 Value { get; }
        public Int32 Amount { get; }
    }

}

