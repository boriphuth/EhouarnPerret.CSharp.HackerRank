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
using System.Text;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day16Sorting
{
    public static class Extensions
    {
        public static void ConsoleWriteLineMinimumAbsoluteDifferencePairs(this Int32[] source)
        {
            // Cannot really use the Insertion Sort here... too slow
            // Let's go with this kind of builtin QuickSort below
            Array.Sort(source);

            var minimumAbsoluteDifference = Math.Abs(source[0] - source[1]);

            var stringBuilder = new StringBuilder(source.Length * 4);

            for (var i = 0; i < (source.Length - 1); i++)
            {
                var currentAbsoluteDifference = Math.Abs(source[i] - source[i + 1]);

                if (currentAbsoluteDifference < minimumAbsoluteDifference)
                {
                    minimumAbsoluteDifference = currentAbsoluteDifference;

                    stringBuilder.Clear();

                    stringBuilder.Append(source[i]);
                    stringBuilder.Append(' ');
                    stringBuilder.Append(source[i + 1]);
                    stringBuilder.Append(' ');
                }
                else if (currentAbsoluteDifference == minimumAbsoluteDifference)
                {
                    stringBuilder.Append(source[i]);
                    stringBuilder.Append(' ');
                    stringBuilder.Append(source[i + 1]);
                    stringBuilder.Append(' ');
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
