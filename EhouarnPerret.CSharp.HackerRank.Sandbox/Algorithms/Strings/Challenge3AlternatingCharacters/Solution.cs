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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Strings.Challenge3AlternatingCharacters
{
    public static class Solution
    {

        // The main trick here is not actually not delete but just to count 
        // How many would have been deleted...
        public static void Main(params String[] arguments)
        {
            var testCaseCount = Convert.ToInt32(Console.ReadLine());

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                var value = Console.ReadLine();

                var deletionCount = 0;

                var previous = value[0];

                for (var i = 1; i < value.Length; i++)
                {
                    var current = value[i];

                    if (current == previous)
                    {
                        deletionCount++;
                    }
                    else
                    {
                        previous = current;
                    }
                }

                Console.WriteLine(deletionCount);
            }
        }
    }
}

