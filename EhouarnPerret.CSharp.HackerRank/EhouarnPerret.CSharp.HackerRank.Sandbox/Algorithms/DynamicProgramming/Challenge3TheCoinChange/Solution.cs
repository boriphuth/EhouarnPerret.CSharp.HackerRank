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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.DynamicProgramming.Challenge3TheCoinChange
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var nmString = Console.ReadLine();
            var nmStringTokens = nmString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var n = Convert.ToInt32(nmStringTokens[0]);
            var m = Convert.ToInt32(nmStringTokens[1]);

            var coinsString = Console.ReadLine();
            var coinsStringTokens = coinsString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var coins = new HashSet<Int32>(coinsStringTokens.Select(item => Convert.ToInt32(item)));

            if (coins.Count != m)
            {
                throw new ArgumentOutOfRangeException(nameof(coins));
            }
            else
            {
                Console.WriteLine(CountCoinChanges);
            }
        }

        public static Int32 CountCoinChanges(Int32 n, Int32 m, HashSet<Int32> coins)
        {
            
        }
    }
}

