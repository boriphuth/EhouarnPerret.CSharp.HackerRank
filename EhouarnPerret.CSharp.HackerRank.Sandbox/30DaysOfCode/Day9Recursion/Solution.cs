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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day9Recursion
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var arrayString = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var x = Convert.ToUInt32(arrayString[0]);
            var y = Convert.ToUInt32(arrayString[1]);

            var xyGCD = Solution.ComputeIterativeGCD(x, y);

            Console.WriteLine(xyGCD);
        }

        // Recursive Euclid's algorithm
        // Seems the stack space is much smaller for the .NET runtime than when running on the JVM
        private static UInt32 ComputeRecursiveGCD(UInt32 x, UInt32 y)
        {
            if (x == y)
            {
                return x;
            }
            else
            {
                // Originally Euclid's algorithm was as follows:
                // var tempY = Math.Min(x, y);
                // var tempX = Math.Max(x, y) - tempY;
                // return Solution.ComputeRecursiveGCD(tempX, tempY);

                // Nowadays you can be better off with:
                return Solution.ComputeRecursiveGCD(y, x % y);
            }
        }
            
        // Iterative Euclid's algorithm
        private static UInt32 ComputeIterativeGCD(UInt32 x, UInt32 y)
        {
            while (y != 0)
            {
                var temp = y;
                y = x % y;
                x = temp;
            }

            return x; 
        }
    }
}

