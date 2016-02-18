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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge3UtopeanTree
{
    public static class Solution
    {
        // Oki the trick here is to notice... an arithmetico-geometric sequence
        // How's that? Quite simple actually
        // Un = a^n (U0 - r) + r
        // Where r = b / (1 - a)
        // In our case U0 = 1 = Height at the beginning
        // a = 2 (double the height during the spring)
        // b = 1 (add 1 when it's summer)
        // Thus r = 1 / (1 - 2) = -1
        // And Un = 2^n (1 - (-1)) + -1
        // <=> Un = 2^n (2) - 1
        // <=> Un = 2^(n + 1) - 1
        // This is applicable one cumulated duration of spring and summer for starting
        // So applicable starting with a cycle count equal to 2
        // Odd numbers of cycle count are reflecting summers
        // Even numbers of cycle count are reflecting spring

        // Note seems there is a binary pattern:
        // cycle count = 0 => 1      1
        // cycle count = 1 => 2     10
        // cycle count = 2 => 3     11
        // cycle count = 3 => 6    110
        // cycle count = 4 => 7    111
        // cycle count = 5 => 14  1110
        // cycle count = 6 => 15  1111

        // For a year cycle (spring + summer):
        // cycle count = 0 => 1      1
        // cycle count = 2 => 3     11
        // cycle count = 4 => 7    111
        // cycle count = 6 => 15  1111 
        // cycleCount >> 1: divides by 2 to get the year
        // << cycleCount % 2: double if the cycle is odd
        // To sum-up: 
        // ((1 << ( (n >> 1) + 1) ) -1 ) << n%2
        // or using the Not logical operator:
        // ~(~1 << (n >> 1)) << n%2

        public static void Main(params String[] arguments)
        {
            var testCaseCount = Convert.ToUInt32(Console.ReadLine());

            const Int32 a = 2;              // Spring double effect
            const Int32 b = 1;              // Summer increase
            const Int32 r = b / (1 - a);    // Arithmetic progression
            const Int32 u0 = 1;             // Initial height

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                var cycleCount = Int32.Parse(Console.ReadLine());

                // Utopean Tree Height
                var un = u0;

                if (cycleCount > 0)
                {
                    var isCycleCountOdd = cycleCount.IsOdd();

                    var springPlusSummerCount = isCycleCountOdd ? (cycleCount + 1) / 2 : cycleCount / 2;

                    un = (Int32)Math.Pow(a, springPlusSummerCount) * (u0 - r) + r;

                    if (isCycleCountOdd)
                    {
                        un--;
                    }
                }

                var binaryPatternTrick = ~(~1 << (cycleCount >> 1)) << cycleCount % 2;

                if (binaryPatternTrick != un)
                {
                    throw new InvalidOperationException();
                }

                Console.WriteLine(un);
            }
        }
    }
}

