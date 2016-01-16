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
using System.Linq;
using System.Collections.Generic;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Sorting.Challenge2InsertionSortPart1
{
    public static class Solution
    {
        public static void Main(params String[] arguments) 
        {
            var n = 10; //Convert.ToInt32(Console.ReadLine());

            var array = new Int32 [n];

            // Console.ReadLine()
            var arrayStringTokens = @"2 3 4 5 6 7 8 9 10 1".Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var list = Array.ConvertAll(arrayStringTokens, Convert.ToInt32).ToList();

            // The last one is the item to insert in the sorted list.
            var e = list[n - 1];

            list.RemoveAt(list.Count - 1);

            // Recreate virtually the situation, sorted array / list
            list.Sort();

            // Add the extracted item to insert
            list.Add(e);

            // Convert to an array as expected
            array = list.ToArray();

            array.SortedInsertionSorted();
        }
    }
}

