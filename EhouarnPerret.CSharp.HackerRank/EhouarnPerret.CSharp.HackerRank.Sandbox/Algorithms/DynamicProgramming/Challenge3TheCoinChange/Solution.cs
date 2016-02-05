﻿//
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
using System.Collections.Generic;
using System.Linq;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.DynamicProgramming.Challenge3TheCoinChange
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var valueCoinCountString = @"4 3"; //Console.ReadLine();
            var valueCoinCountStringTokens = valueCoinCountString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var value = Convert.ToInt32(valueCoinCountStringTokens[0]);
            var coinCount = Convert.ToInt32(valueCoinCountStringTokens[1]);

            var coinsString = @"1 2 3"; //Console.ReadLine();
            var coinsStringTokens = coinsString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var coins = Array.ConvertAll(coinsStringTokens, Convert.ToInt32);

            if (coins.Length != coinCount)
            {
                throw new ArgumentOutOfRangeException(nameof(coins));
            }
            else
            {
                Console.WriteLine(Solution.RecursiveCountCoinChanges(value, coins.Length,  coins, String.Empty));
            }
        }

        public static UInt32 RecursiveCountCoinChanges(Int32 value, Int32 coinCount, IList<Int32> coins, String str)
        {
            Console.WriteLine(@"Call(value = {0}, coinCount = {1}, coins = {2})", value, coinCount, String.Join(@" ", coins.Take(coinCount)));

            // Terminal conditions
            // Value is zero then... we dot not need any coin
            if (value == 0)
            {
                Console.WriteLine(@"Solution: " + str);
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
                // Solution of the problem is sum of the subproblems WITH the [cointCount - 1]th coin and WITHOUT [cointCount - 1]th coin
                return Solution.RecursiveCountCoinChanges(value, coinCount - 1, coins, str) + Solution.RecursiveCountCoinChanges(value - coins[coinCount - 1], coinCount, coins, str + coins[coinCount - 1] + " ");
            }
        }

        public static UInt32 IterativeCountCoinChanges(Int32 value, Int32 coinCount, IList<Int32> coins, String str)
        {
            Console.WriteLine(@"Call(value = {0}, coinCount = {1}, coins = {2})", value, coinCount, String.Join(@" ", coins.Take(coinCount)));

            // Terminal conditions
            // Value is zero then... we dot not need any coin
            if (value == 0)
            {
                Console.WriteLine(@"Solution: " + str);
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
                // Solution of the problem is sum of the subproblems WITH the [cointCount - 1]th coin and WITHOUT [cointCount - 1]th coin
                return Solution.RecursiveCountCoinChanges(value, coinCount - 1, coins, str) + Solution.RecursiveCountCoinChanges(value - coins[coinCount - 1], coinCount, coins, str + coins[coinCount - 1] + " ");
            }
        }
    }
   
}

