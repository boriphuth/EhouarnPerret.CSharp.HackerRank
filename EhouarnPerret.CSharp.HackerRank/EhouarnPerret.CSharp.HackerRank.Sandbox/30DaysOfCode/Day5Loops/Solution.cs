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
using System.Text;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day5Loops
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var testCaseCount = Int32.Parse(Console.ReadLine());

            for (var i = 0; i < testCaseCount; i++)
            {
                var parametersTokens = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var a = Int32.Parse(parametersTokens[0]);

                var b = Int32.Parse(parametersTokens[1]);

                var n = Int32.Parse(parametersTokens[2]);

                var sum = a;

                var stringBuilder = new StringBuilder();

                for (var j = 0; j < n; j++) 
                {
                    sum += Convert.ToInt32(Math.Pow(2, j) * b);

                    stringBuilder.Append(sum);

                    stringBuilder.Append(' ');
                }

                Console.WriteLine(stringBuilder.ToString());
            }
        }
    }
}

