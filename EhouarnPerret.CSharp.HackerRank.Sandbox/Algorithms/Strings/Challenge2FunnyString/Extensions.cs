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
using System.Net.NetworkInformation;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Strings.Challenge2FunnyString
{
    public static class Extensions
    {
        /// <summary>
        /// Determines if is funny the specified value.
        /// Using the given algorithm on HackerRank.
        /// </summary>
        /// <returns><c>true</c> if the specified value is funny; otherwise, <c>false</c>.</returns>
        /// <param name="value">Value.</param>
        public static Boolean IsFunny(this String value)
        {
            var reversedValue = value.Reverse();

            for (var i = 1; i < value.Length; i++)
            {
                var difference = Math.Abs(value[i] - value[i - 1]);
                var reversedDifference = Math.Abs(reversedValue[i] - reversedValue[i - 1]);

                if (difference != reversedDifference)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Reverse the specified value.
        /// </summary>
        /// <param name="value">Value.</param>
        public static String Reverse(this String value)
        {
            var characters = value.ToCharArray();
            Array.Reverse(characters);
            return new String(characters);
        }
    }
}
