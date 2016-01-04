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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day1DataTypes
{
    /// <summary>
    /// The code below stinks but it has been accepted by HackerRank...
    /// Actually a better solution was refused...
    /// Starting to wonder about the relevancy of such tests
    /// </summary>
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var values = new Object[]
            {
                5.35,
                'a',
                false,
                100,
                "I am a code monkey",
                true,
                17.3,
                'c',
                "derp",
            };

            foreach(var value in values)
            {
                var valueType = value.GetType();

                var valueTypeCategory = valueType.IsPrimitive ? @"Primitive" : "Referenced";

                var valueTypeName = String.Empty;

                if (valueType.Name == @"Char")
                {
                    valueTypeName = @"Character";
                }
                else if (valueType.Name.Contains(@"Int")) 
                {
                    valueTypeName = @"Integer";
                }
                else
                {
                    valueTypeName = valueType.Name;
                }

                Console.WriteLine(valueTypeCategory + " : " + valueTypeName);
            }
        }
    }
}

