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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day26TestingPartImplementations
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var actualReturnDateString = Console.ReadLine();
            var expectedReturnDateString = Console.ReadLine();

            var actualReturnDateTokens = Array.ConvertAll(actualReturnDateString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
            var expectedReturnDateTokens = Array.ConvertAll(expectedReturnDateString.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
        
            var actualReturnDateTime = new DateTime(actualReturnDateTokens[2], actualReturnDateTokens[1], actualReturnDateTokens[0]);
            var expectedReturnDateTime = new DateTime(expectedReturnDateTokens[2], expectedReturnDateTokens[1], expectedReturnDateTokens[0]);
        
            var hackosFine = default(Int32);

            if (expectedReturnDateTime >= actualReturnDateTime)
            {
                hackosFine = 0;
            }
            else if (expectedReturnDateTime.Year == actualReturnDateTime.Year)
            {
                if (expectedReturnDateTime.Month == actualReturnDateTime.Month)
                {
                    hackosFine = (actualReturnDateTime.Day - expectedReturnDateTime.Day) * 15;
                }
                else
                {
                    hackosFine = (actualReturnDateTime.Month - expectedReturnDateTime.Month) * 500;
                }
            }
            else
            {
                hackosFine = 10000;
            }

            Console.WriteLine(hackosFine);
        }
    }
}

