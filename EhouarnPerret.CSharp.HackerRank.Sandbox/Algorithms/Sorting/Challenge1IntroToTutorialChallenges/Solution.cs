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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Sorting.Challenge1IntroToTutorialChallenges
{
    public static class Solution
    {
        public static void Main(params String[] arguments) 
        {
            var value = Convert.ToInt32(Console.ReadLine());

            var n = Convert.ToInt32(Console.ReadLine());

            var arrayString = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var array = Array.ConvertAll(arrayString, Convert.ToInt32);

            if (array.Length != n)
            {
                throw new ArgumentException(nameof(n));
            }
            else
            {
                // Same as an IndexOf(value) call ... almost
                for (var i = 0; i < array.Length; i++)
                {
                    if (value == array[i])
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}

