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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Sorting.Challenge2InsertionSortPart1
{
    public static class Extensions
    {
        // Supposedly on an already sorted array
        public static void InsertionSort<TComparable>(this IList<TComparable> source) 
            where TComparable : IComparable<TComparable>
        {
            // Except the rightmost cell which is the black sheep
            var e = source.Last();

            var isInsertionDone = false;

            for (var i = source.Count - 2; i >= 0; i--)
            {
                var item = source[i];

                if (item.CompareTo(e) > 0)
                {
                    source[i + 1] = item;
                }
                else if ((item.CompareTo(e) <= 0))
                {
                    source[i + 1] = e;

                    isInsertionDone = true;
                }

                source.WriteToConsole();

                if (isInsertionDone)
                {
                    break;
                }
            }

            if (!isInsertionDone)
            {
                source[0] = e;

                source.WriteToConsole();
            }
        }

        private static void WriteToConsole<T>(this IEnumerable<T> source, String separator = @" ")
        {
            Console.WriteLine(String.Join(separator, source));
        }
    }
}
