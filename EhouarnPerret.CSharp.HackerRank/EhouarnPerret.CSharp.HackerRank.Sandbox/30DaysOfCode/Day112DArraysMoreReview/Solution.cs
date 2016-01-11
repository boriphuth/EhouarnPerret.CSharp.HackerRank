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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day112DArraysMoreReview
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            const Int32 squareDimension = 6;
            const Int32 hourglassSquareDimension = 3;

            // Just for the sake of clarity, think about the center
            // And the number just above =]
            // const Int32 hourglassCenterMiddleOffset = 1;
            var a = new Int32[squareDimension , squareDimension];

            // 2 { 0, 1 }
            // var dimensions = a.Rank;
            // Silly but comprehensive
            var rowCount = a.GetLength(0);
            var columnCount = a.GetLength(1);

            for(var i = 0; i < squareDimension; i++)
            {
                var aRowStringTokens = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var aRow = Array.ConvertAll(aRowStringTokens, Int32.Parse);

                for (var j = 0; j < aRow.Length; j++)
                {
                    a[i, j] = aRow[j];
                }
            }

            // Array Example:
            // a = new Int32[squareDimension , squareDimension]
            // {
            //    { 1, 1, 1, 0, 0, 0 },
            //    { 0, 1, 0, 0, 0, 0 },
            //    { 1, 1, 1, 0, 0, 0 },
            //    { 0, 0, 2, 4, 4, 0 },
            //    { 0, 0, 0, 2, 0, 0 },
            //    { 0, 0, 1, 2, 4, 0 },
            // } ;
            //
            // Hourglass Pattern:
            // ***
            //  *
            // ***

            // The overlapping effect...
            var rowHourglassCount = rowCount - hourglassSquareDimension + 1;
            var columnHourglassCount = columnCount - hourglassSquareDimension + 1;
           
            // Maximum value initialized to the minimum
            var maxSum = Int32.MinValue; 

            // In this particular case only 16 cases to check
            for(var i = 0 ; i < rowHourglassCount; i++)
            {
                for(var j = 0 ; j < columnHourglassCount; j++)
                {
                    // var topLeft = a[i, j];
                    // var topCenter = a[i, j + 1];
                    // var topRight = a[i, j + 2];
                    // var middleCenter = a[i + 1, j + 1];
                    // var bottomLeft = a[i + 2, j];
                    // var bottomCenter = a[i + 2, j + 1];
                    // var bottomRight = a[i + 2, j + 2];

                    // Sum all the hourglass slots...
                    var currentSum = (a[i, j] + a[i, j + 1] + a[i, j + 2] + a[i + 1, j + 1] + a[i + 2, j] + a[i + 2, j + 1] + a[i + 2, j + 2]);

                    // Compare current sum with maximum sum
                    // Replace maximum if current sum is greater than maximum sum...
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            // Display something if we have to something to show...
            if (maxSum > Int32.MinValue)
            {
                Console.WriteLine(maxSum);
            }
        }
    }
}

