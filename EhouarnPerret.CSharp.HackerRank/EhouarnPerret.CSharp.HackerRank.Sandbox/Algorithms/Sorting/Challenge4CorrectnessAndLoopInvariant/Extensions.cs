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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Sorting.Challenge4CorrectnessAndLoopInvariant
{
    public static class Extensions
    {
        /// <summary>
        /// Insertion sort for alread sorted data except the last one.
        /// </summary>
        /// <returns>The number of shifts required to sort.</returns>
        /// <param name="source">Source.</param>
        /// <param name="itemToSortIndex">Item to sort index.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        private static void SortedInsertionSort<T>(this IList<T> source, Int32 itemToSortIndex) 
        {
            // Except the rightmost cell which is the black sheep
            var e = source[itemToSortIndex];

            var j = itemToSortIndex - 1;

            var comparer = Comparer<T>.Default;

            // The mistake is that basically it was j > 0 instead of j >= 0...
            while ((j >= 0) && (comparer.Compare(source[j], e) > 0))
            {
                source.ShiftToRight(j);

                j--;
            }

            source[j + 1] = e;
        }

        private static void ShiftToRight<T>(this IList<T> source, Int32 index)
        {
            source[index + 1] = source[index];
        }

        public static void InsertionSort<TComparable>(this IList<TComparable> source)
            where TComparable : IComparable<TComparable>
        {
            // Starts from i = 1 => micro-optimization => "already sorted"
            for (var i = 1; i < source.Count; i++)
            {
                source.SortedInsertionSort(i);
            }
        }

        public static void WriteLineToConsole<T>(this IEnumerable<T> source, String separator = @" ")
        {
            Console.WriteLine(String.Join(separator, source));
        }
    }
}
