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
using System.Collections.Generic;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Sorting.Challenge5RunningTimeOfAlgorithms
{
    public static class Extensions
    {
        // Supposedly on an already sorted array
        private static UInt32 SortedInsertionSort<T>(this IList<T> source, Int32 itemToSortIndex) 
        {
            var shiftCount = 0u;

            // Except the rightmost cell which is the black sheep
            var e = source[itemToSortIndex];

            var j = itemToSortIndex - 1;

            var comparer = Comparer<T>.Default;

            while ((j >= 0) && (comparer.Compare(source[j], e) > 0))
            {
                source.ShiftToRight(j);

                shiftCount++;

                j--;
            }

            source[j + 1] = e;

            // This time we do not print anything
            // source.WriteLineToConsole();

            return shiftCount;
        }

        private static void ShiftToRight<T>(this IList<T> source, Int32 index)
        {
            source[index + 1] = source[index];
        }

        public static UInt32 InsertionSort<T>(this IList<T> source)
        {
            var shiftCount = 0u;

            // Starts from i = 1 => micro-optimization => "already sorted"
            for (var i = 1; i < source.Count; i++)
            {
                shiftCount += source.SortedInsertionSort(i);
            }

            return shiftCount;
        }

        private static void WriteLineToConsole<T>(this IEnumerable<T> source, String separator = @" ")
        {
            Console.WriteLine(String.Join(separator, source));
        }
    }
}
