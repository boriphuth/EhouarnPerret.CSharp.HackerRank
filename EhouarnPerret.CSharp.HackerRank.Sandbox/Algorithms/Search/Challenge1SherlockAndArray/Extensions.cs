//
// Extensions.cs
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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Search.Challenge1SherlockAndArray
{

    public static class Extensions
    {
        public static Int32 FindEquilibriumIndex(this Int32[] value)
        {
            if (value.Length == 1)
            {
                return 0;
            }
            else if (value.Length == 2)
            {
                return -1;
            }
            else
            {
                // O(n)
                var sum = value.Sum();

                var leftSum = value[0];

                // O(n)
                for (var i = 1; i < value.Length; i++)
                {
                    var rightSum = sum - leftSum - value[i];

                    if (leftSum == rightSum)
                    {
                        return i;
                    }

                    leftSum += value[i];
                }

                // ... O(n) = O(2n)

                return -1;
            }
        }
    }
}
