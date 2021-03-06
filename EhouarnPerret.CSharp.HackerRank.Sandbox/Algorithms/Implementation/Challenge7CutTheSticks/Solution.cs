﻿//
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
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge7CutTheSticks
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var stickLengthsString = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var stickLengths = Array.ConvertAll(stickLengthsString, Int32.Parse).Take(n).OrderBy(item => item).ToList();
            stickLengths.Sort();

            while (stickLengths.Count > 0)
            {
                var cutStickCount = 0;

                var cutLength = stickLengths[0];

                for (var i = 0; i < stickLengths.Count; i++)
                {
                    stickLengths[i] -= cutLength;

                    cutStickCount++;

                    if (stickLengths[i] <= 0)
                    {
                        stickLengths.RemoveAt(i);

                        i--;
                    }
                }

                Console.WriteLine(cutStickCount);
            }
        }
    }
}

