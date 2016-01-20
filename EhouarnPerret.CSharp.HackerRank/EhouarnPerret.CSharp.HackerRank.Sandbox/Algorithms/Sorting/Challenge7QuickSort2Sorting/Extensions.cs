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

using System.Linq;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Sorting.Challenge7QuickSort2Sorting
{
    public static class Extensions
    {
        // Does not need inplace operations like swap or others since we need to keep the orignal order
        public static IEnumerable<T> OrderedPartition<T>(this IEnumerable<T> source)
        {
            var comparer = Comparer<T>.Default;

            var pivot = source.First();

            var smaller = new List<T>();

            var greater = new List<T>();

            foreach (var item in source.Skip(1))
            {
                var comparison = comparer.Compare(item, pivot) < 0;

                Console.WriteLine(@"{1} < {0} = {2}", pivot, item, comparison);

                if (comparison)
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }

            smaller.Add(pivot);

            smaller.AddRange(greater);

            return smaller;
        }

        public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> source)
        {
            return null;
        }

        public static void WriteLineToConsole<T>(this IEnumerable<T> source, String separator = @" ")
        {
            Console.WriteLine(String.Join(separator, source));
        }
    }
}

