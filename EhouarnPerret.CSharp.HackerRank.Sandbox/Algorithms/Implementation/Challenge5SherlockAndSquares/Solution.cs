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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge5SherlockAndSquares
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var testCaseCount = Convert.ToUInt32(Console.ReadLine());

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                // Wikipedia:
                // "A square number or perfect square is an integer that is the square of an integer;
                // in other words, it is the product of some integer with itself."

                // Long story short: the square function is stricly increasing over between [a, b]
                // Where a < b
                // We can leverage the Intermediate value theorem below
                // "If a continuous function, f, with an interval, [a, b],
                // as its domain, takes values f(a) and f(b) at each end of the interval,
                // then it also takes any value between f(a) and f(b) at some point within the interval."

                // Basically, say we have, potentially a certain number of perfect root squares (noted, xi) within [a, b]
                // => a <= x1 < x2 < x3 <= b  <=> a <= ... xi ... <= b
                // => sqrt(a) <= ... sqrt(xi) ... < sqrt(b)

                // Since we are looking for perfect squares, the related root squares are also integers
                // E.g. between two and 1 and 10, how many perfect squares?
                // sqrt(1) = 1 (seems to be a perfect square) and sqrt(10) = 3.16
                // What are the integers within [1, 3]?
                // Those integers in this interval are the root sqaures 
                // of the perfect Square numbers we are looking for...
                // Since we root square the initial given interval itself
                // So for that example the answer 1, 2, 3...
                // are the root squares values of these respective 
                // perfect square values: 1, 4, 9
                // Hope it makes some sense now =]

                var abStringTokens = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var a = Int32.Parse(abStringTokens[0]);
                var b = Int32.Parse(abStringTokens[1]);

                var aRootSquare = Math.Sqrt(a);
                var bRootSquare = Math.Sqrt(b);

                var aFlooredRootSquare = Math.Floor(aRootSquare);
                var bFlooredRootSquare = Math.Floor(bRootSquare);

                var closestAPerfectRootSquare = Convert.ToInt32(aFlooredRootSquare);
                var closestBPerfectRootSquare = Convert.ToInt32(bFlooredRootSquare);

                var isAPerfectSquare = closestAPerfectRootSquare == aRootSquare;

                var perfectSquareCount = isAPerfectSquare ? 1 : 0;
                perfectSquareCount += closestBPerfectRootSquare - closestAPerfectRootSquare;

                Console.WriteLine(perfectSquareCount);
            }
        }
    }
}

