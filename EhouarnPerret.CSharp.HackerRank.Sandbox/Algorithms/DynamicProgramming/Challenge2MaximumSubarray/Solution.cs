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
using System.IO;


namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.DynamicProgramming.Challenge2MaximumSubarray
{
    public class DateTimeWordFormatProvider : IFormatProvider
    {
        #region IFormatProvider Implementation
        public object GetFormat(Type formatType)
        {
            throw new NotImplementedException();
        }
        #endregion
        
    }

    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var re =  DateTime.Now.ToString(new DateTimeWordFormatProvider());

            var text = File.ReadAllLines(@"C:\Users\Ehouarn\Desktop\Thing.txt");

            var testCaseCount = text.Length / 2; //Int32.Parse(Console.ReadLine());

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                var n = Convert.ToInt32(text[testCase * 2]); //Convert.ToUInt16(Console.ReadLine());
                // Console.ReadLine()
                var arrayStringTokens = text[testCase * 2 + 1].Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (n != arrayStringTokens.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(arrayStringTokens));
                }
                else
                {
                    var array = Array.ConvertAll(arrayStringTokens, Int32.Parse);

                    Console.WriteLine(array.Sums());
                }
            }
        }
    }
}

