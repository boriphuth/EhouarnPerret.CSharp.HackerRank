//
// TestCase.cs
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
using EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day12Inheritance;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day27TestingPart2
{
    /// <summary>
    /// Test case.
    /// ArrivalTimes must have at least one zero, one positive integer, and one negative integer.
    /// The value of CancellationThreshold should be distinct across all the test cases. 
    /// </summary>
    public class TestCase
    {
        private static IEnumerable<Int32> ToInt32Enumerable(String value)
        {
            return value
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => Convert.ToInt32(item));
        }

        public TestCase(Int32 cancellationThreshold, IEnumerable<Int32> arrivalTimes)
        {
            this.ArrivalTimes = arrivalTimes;

            this.CancellationThreshold = cancellationThreshold;

            var onTimeStudentCount = 0;

            var studentCount = 0;

            foreach (var arrivalTime in arrivalTimes)
            {
                studentCount++;

                if (arrivalTime <= 0)
                {
                    onTimeStudentCount++;
                }
            }

            this.IsCancelled = onTimeStudentCount < cancellationThreshold;

            this.StudentCount = studentCount;

            this.IsCancelled = this.CancellationThreshold > onTimeStudentCount;
        }

        public TestCase(String cancellationThresholdString, String arrivalTimesString)
            : this(Convert.ToInt32(cancellationThresholdString), TestCase.ToInt32Enumerable(arrivalTimesString))
        {
        }

        public Int32 StudentCount { get; }

        public Int32 CancellationThreshold { get; }

        public IEnumerable<Int32> ArrivalTimes { get; }

        public Boolean IsCancelled { get; }
    }
}
