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
using System.Text;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge4FindDigits
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var testCaseCount = Convert.ToUInt32(Console.ReadLine());

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                var numberString = Console.ReadLine();
                var number = Int64.Parse(numberString);

                // If we assume that the hashcode computation algorithm is much slower than the one involved in a modulo operation...
                // then we can be much better off as follows:
                var evenlyDivisorCount = numberString
                    .Select(character => character.ToByte())
                    .Count(digit => (digit != 0) && number.IsDivisbleBy(digit));

                Console.WriteLine(evenlyDivisorCount);

                // Otherwise for the full, lengthy and verbosed solution see below
                // (Non-healthy optimizations just to give the gist...)
                //                var evenlyDivisors = new HashSet<Byte>();
                //                var nonEvenlyDivisors = new HashSet<Byte>();
                //
                //                var evenlyDivisorCount = 0;
                //
                //                foreach (var digit in digits)
                //                {
                //                    // What a optimization... non-divisble by 0...
                //                    if (digit != 0)
                //                    {
                //                        if (!nonEvenlyDivisors.Contains(digit) && !evenlyDivisors.Contains(digit))
                //                        {
                //                            if (number.IsDivisbleBy(digit))
                //                            {
                //                                evenlyDivisors.Add(digit);
                //                                evenlyDivisorCount++;
                //                            }
                //                            else
                //                            {
                //                                nonEvenlyDivisors.Add(digit);
                //                            }
                //                        }
                //                        // Already know that the number is divisble by this digit
                //                        else if (!nonEvenlyDivisors.Contains(digit) && evenlyDivisors.Contains(digit))
                //                        {
                //                            evenlyDivisorCount++;
                //                        }
                //                    }
                //                }
            }
        }
    }
}

