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
using EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day19Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day19Interfaces
{

    public static class Extensions
    {
        public static IEnumerable<Int32> ToFactors(this Int32 value)
        {
            var squareRoot = Convert.ToInt32(Math.Floor (Math.Sqrt(value)));

            for (var factor = 1; factor <= squareRoot; factor++)
            {
                if(value % factor == 0)
                {
                    yield return factor;

                    // We don't have to add the square root twice
                    if (factor != (value / factor))
                    { 
                        yield return value / factor;
                    }
                }
            }
        }
    }
}