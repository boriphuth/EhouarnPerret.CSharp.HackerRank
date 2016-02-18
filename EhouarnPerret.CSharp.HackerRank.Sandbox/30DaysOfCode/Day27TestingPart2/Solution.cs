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
using System.Collections.Generic;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day27TestingPart2
{
    public static class Solution
    {
        public static void Main(params String[] arguments) 
        {
            // Create the test cases leading to:
            // YES
            // NO
            // YES
            // NO
            // YES
            // etc.

            var testCaseCount = 5;

            var testCases = Solution.GenerateTestCases(testCaseCount);

            Console.WriteLine(testCaseCount);

            foreach (var testCase in testCases)
            {
                Console.WriteLine(testCase.StudentCount + " " + testCase.CancellationThreshold);
                Console.WriteLine(String.Join(@" ", testCase.ArrivalTimes));
                //Console.WriteLine(testCase.IsCancelled ? @"YES" : @"NO");
            }
        }

        private static IEnumerable<TestCase> GenerateTestCases(Int32 testCaseCount)
        {
            var testCaseDatum = new List<TestCase>(testCaseCount);

            for (var testCase = 0; testCase < testCaseCount; testCase++) 
            {
                var arrivalTimes = new List<Int32>(new [] { -1, 0, 1 });

                var newArrivalTime = (testCase % 2 == 0) ? 1 : -1;

                for (var i = 0; i < testCase; i++)
                {
                    arrivalTimes.Add(newArrivalTime);
                }

                var cancellationThreshold = (testCase % 2 == 0) ? arrivalTimes.Count : arrivalTimes.Count - 2;

                var testCaseData = new TestCase(cancellationThreshold, arrivalTimes);

                testCaseDatum.Add(testCaseData);
            }

            return testCaseDatum;
        }
    }
}

