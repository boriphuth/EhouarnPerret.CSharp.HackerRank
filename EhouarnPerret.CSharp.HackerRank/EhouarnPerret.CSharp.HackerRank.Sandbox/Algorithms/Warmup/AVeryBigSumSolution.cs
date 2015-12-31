// File: AVeryBigSumSolution.cs
// Author: Ehouarn Perret
// Email: ehouarn.perret@art-logics.com
// Company: ART logics
// Website: http://www.art-logics.com
// Copyright: ART logics © All Rights Reserved.
using System;
using System.Numerics;
using System.Collections.Generic;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Warmup
{
    public static class AVeryBigSumSolution
    {
        public static void Main(params String[] arguments) 
        {
            const Char separator = ' ';

            var n = Convert.ToInt32(Console.ReadLine());

            var userInputTokens = Console.ReadLine().Split(new [] { separator }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = Array.ConvertAll(userInputTokens, BigInteger.Parse);

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

    public static class BigIntegerExtensions
    {
        public static BigInteger Sum(this IEnumerable<BigInteger> source)
        {
            var sum = BigInteger.Zero;

            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }
    }
}

