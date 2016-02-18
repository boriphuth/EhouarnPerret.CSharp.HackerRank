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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.BitManipulation.Challenge2MaximizingXOR
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var left = Convert.ToInt32(Console.ReadLine());
            var right = Convert.ToInt32(Console.ReadLine());
            var result = Solution.MaxXor(left, right);

            Console.WriteLine(result);
        }

        public static Int32 MaxXor(Int32 left, Int32 right)
        {
            // First bit to 1 is where left and right start to differ.
            var result = left ^ right;
           
            // Let's take the bits representation length associated to the result
            var resultBitLength = Math.Floor(Math.Log(result, 2) + 1);

            // Then we get the number related number to this 1 bits long representation
            var max = Convert.ToInt32(Math.Pow(2, resultBitLength) - 1);

            return max;
        }
    }
}

