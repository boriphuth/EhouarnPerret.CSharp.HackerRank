//
// Extensions.cs
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
using System.Net;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge2SherlockandTheBeast
{
    // Decent Number is defined as follows: 
    // * 3 and 5 digits only
    // * 3's count divisible by 5 
    // * 5's count divisible by 3 
    public static class Extensions
    {
        public static Boolean IsAMultipleOf(this Int32 value, Int32 other)
        {
            return value % other == 0;
        }

        // Decent Number is defined as follows: 
        // * 3 and 5 digits only
        // * 3's count divisible by 5 
        // * 5's count divisible by 3 
        // In our situation: 3×x + 5×y = N 
        // <=> Diophantine Equation
        // <=> a×x + b×y = c
        // There is a solution if and only if c is multiple of GCD(a, b)
        // a = 3, b = 5
        // GCD(a, b) resolution:
        // 5 = 3×1 + 2;
        // 3 = 2×1 + 1
        // => GCD(a, b) = 1 = 3 - 2×1
        // Also 2 = 5 - 3×1
        // So put altogether we have:
        // <=> 1 = 3 - (5 - 3×1) × 1
        // <=> 1 = 3 - 5×1 + 3×1
        // <=> 1 = 3×2 + 5×(-1)
        // <=> N×1 = N × (3×2 + 5×(-1))
        // <=> N = 3×2×N + 5×(-1)×N)
        // <=> N = 3×x + 5×y
        // => (x, y) = (2×N, -1×N) a simple solution
        // Other solutions are of the form (x + k×v, y - k×u)
        // Where u = a / GCD(a, b) and v = b / GCD(a, b)
        // Consequently other solutions are (x + k×5 / 1, y - k×3 / 1)
        // That is (x + 5×k, y + 3×k)
        // Therefore: 2 . N = x + 5×k and -1 . N = y - 3×k
        // x = 2×N - 5×k 
        // y = -(1)N + 3×k
        /// <summary>
        /// Finds the largest decent number.
        /// </summary>
        /// <returns>The largest decent number.</returns>
        /// <param name="decentNumberDigitCount">Decent number digit count.</param>
        public static BigInteger? FindLargestDecentNumber(this Int32 decentNumberDigitCount)
        {
            return new BigInteger?();
        }
    }
}
