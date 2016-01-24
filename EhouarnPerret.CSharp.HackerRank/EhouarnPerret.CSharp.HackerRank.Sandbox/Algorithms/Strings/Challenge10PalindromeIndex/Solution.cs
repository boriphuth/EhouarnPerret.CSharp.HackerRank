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
using System.Security.AccessControl;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Strings.Challenge10PalindromeIndex
{
    public static class Solution 
    {
        public static void Main(params String[] arguments)
        {
            var testCaseCount = Convert.ToInt32(Console.ReadLine());

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                var value = Console.ReadLine();

                Console.WriteLine(value.FindPalindromRemovalIndex());
            }
        }

        public static Int32 FindPalindromRemovalIndex(this String value)
        {
            var isValueLengthEven = ((value.Length % 2) == 0);

            for (var i = 0; i <= value.Length / 2; i++)
            {
                var left = value[i];
                var right = value[value.Length - 1 - i];
            }

            return 0;
        }
    }
}

