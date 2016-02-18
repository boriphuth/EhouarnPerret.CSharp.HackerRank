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
using System.Dynamic;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.DynamicProgramming.Challenge2MaximumSubarray
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var testCaseCount = 1; // Int32.Parse(Console.ReadLine());

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                var n = 6; // Convert.ToUInt16(Console.ReadLine());

                var arrayString = @"2 -1 2 3 4 -5".Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var array = Array.ConvertAll(arrayString, Int32.Parse);


            }
        }
    }

    public static class Extensions
    {
        public static SubArraySums Sums<T>(this IList<T> source)
        {
            var contiguousSum = source[0];

            var nonContinguousSum = contiguousSum;

            for (var i = 1; i < source.Count; i++)
            {
                var item = source[i];

                nonContinguousSum += item;
            }

        }
    }

    public struct SubArraySums
    {
        public SubArraySums(Int32 contiguous, Int32 nonContiguous)
        {
            this.Contiguous = contiguous;
            this.NonContiguous = nonContiguous;
        }

        public Int32 Contiguous { get; }
        public Int32 NonContiguous { get; }

        public override String ToString()
        {
            return String.Format(@"{0} {1}", this.Contiguous, this.NonContiguous);
        }
    }
}

