// File: SolveMeFirst.cs
// Author: Ehouarn Perret
// Email: ehouarn.perret@art-logics.com
// Company: ART logics
// Website: http://www.art-logics.com
// Copyright: ART logics © All Rights Reserved.
using System;
using System.Linq;
using System.Diagnostics.Contracts;
using System.Diagnostics;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Warmup.Challenge1SimpleArraySum
{
    public static class Solution
    {
        public static void Main(params String[] arguments) 
        {
            var n = Convert.ToInt32(Console.ReadLine());

            const Char separator = ' ';

            var userInputTokens = Console.ReadLine().Split(new [] { separator }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = Array.ConvertAll(userInputTokens, Int32.Parse);

            if (numbers.Length != n)
            {
                throw new InvalidOperationException();
            }
            else
            {
                var sum = numbers.Sum();

                Console.WriteLine(sum);
            }
        }
    }
}

