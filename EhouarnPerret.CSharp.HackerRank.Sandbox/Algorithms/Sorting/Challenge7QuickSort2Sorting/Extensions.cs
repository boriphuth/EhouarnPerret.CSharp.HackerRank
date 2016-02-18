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
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Sorting.Challenge7QuickSort2Sorting
{
    public static class Extensions
    {
        // Does not need inplace operations like swap or others since we need to keep the orignal order
        public static Int32 OrderedPartition<T>(this IList<T> source, Int32 lowerBound, Int32 upperBound)
        {
            if (lowerBound == upperBound)
            {
                return lowerBound;
            }
            else
            {
                var comparer = Comparer<T>.Default;

                var pivot = source[lowerBound];

                //Console.WriteLine(@"Pivot = {0}", pivot);

                var left = new List<T>();

                var right = new List<T>();

                for (var i = lowerBound + 1; i <= upperBound; i++)
                {
                    var item = source[i];

                    var comparison = comparer.Compare(item, pivot) > 0;

                    //Console.WriteLine(@"{1} < {0} = {2}", pivot, item, comparison);

                    if (comparison)
                    {
                        right.Add(item);
                    }
                    else
                    {
                        left.Add(item);
                    }
                }

                for (var i = 0; i < left.Count; i++)
                {
                    source[i + lowerBound] = left[i];
                }

                var pivotIndex = left.Count + lowerBound - 1;

                source[pivotIndex] = pivot;

                for (var i = 0; i < right.Count; i++)
                {
                    source[i + pivotIndex + 1] = right[i];
                }

                var stringBuilder = new StringBuilder();

                for (var i = lowerBound; i <= upperBound; i++)
                {
                    stringBuilder.Append(source[i]);
                    stringBuilder.Append(' ');
                }

                Console.WriteLine(stringBuilder);

                return pivotIndex;
            }
        }

        public static void QuickSort<T>(this IList<T> source, Int32 lowerBound, Int32 upperBound)
        {
            if (lowerBound < upperBound)
            {
                var pivotIndex = source.OrderedPartition(lowerBound, upperBound);

                source.QuickSort(lowerBound, pivotIndex - 1);

                source.QuickSort(pivotIndex + 1, upperBound);
            }
        }

        public static void QuickSort<T>(this IList<T> source)
        {
            source.QuickSort(0, source.Count - 1);
        }

        public static void WriteLineToConsole<T>(this IEnumerable<T> source, String separator = @" ")
        {
            Console.WriteLine(String.Join(separator, source));
        }

        public static void WriteLineToConsole<T>(this IList<T> source, Int32 lowerBound, Int32 upperBound, String separator = @" ")
        {
            Console.WriteLine(String.Join(separator, source.Skip(lowerBound).Take(upperBound - lowerBound)));
        }
    }
}

