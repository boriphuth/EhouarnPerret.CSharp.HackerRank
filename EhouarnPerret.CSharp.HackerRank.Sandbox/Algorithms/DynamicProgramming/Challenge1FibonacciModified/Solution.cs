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
using System.Numerics;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.DynamicProgramming.Challenge1FibonacciModified
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var input = @"0 1 5"; //Console.ReadLine();

            var inputTokens = input.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var int16InputTokens = Array.ConvertAll(inputTokens, Convert.ToUInt16);

            var a = int16InputTokens[0];

            var b = int16InputTokens[1];

            var n = int16InputTokens[2];

            var result = Solution.ComputeModifiedFibonacci(a, b, n);

            Console.WriteLine(result);
        }

        private static BigInteger ComputeModifiedFibonacciTn2(BigInteger tn, BigInteger tn1)
        {
            return (tn1 * tn1) + tn;
        }

        /// <summary>
        /// Computes the modified fibonacci.
        /// </summary>
        /// <returns>The modified fibonacci.</returns>
        /// <param name="a">The 1st term.</param>
        /// <param name="b">The 2th term.</param>
        /// <param name="n">Nth rank.</param>
        public static BigInteger ComputeModifiedFibonacci(BigInteger a, BigInteger b, UInt16 n)
        {
            switch (n)
            {
                case 0:
                    throw new ArgumentException(nameof(n));
                case 1:
                    return a;
                case 2:
                    return b;

                default:
                    var tn = a;
                    var tn1 = b;
                    var tn2 = Solution.ComputeModifiedFibonacciTn2(tn, tn1);

                    for (var i = 2; i < (n - 1); i++)
                    {
                        tn = tn1;
                        tn1 = tn2;
                        tn2 = Solution.ComputeModifiedFibonacciTn2(tn, tn1);
                    }

                    return tn2;
            }
        }
    }
}

