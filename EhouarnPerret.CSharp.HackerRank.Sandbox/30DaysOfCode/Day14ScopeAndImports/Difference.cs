//
// Difference.cs
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
using System.Collections.ObjectModel;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day14ScopeAndImports
{
    public class Difference
    {
        public Difference(IEnumerable<Int32> elements)
        {
            this.Elements = new ReadOnlyCollection<Int32>(elements.ToList());

            this.MaximumDifference = this.ComputeMaximumDifference(this.Elements as IList<Int32>);
        }

        private Int32 ComputeMaximumDifference (IList<Int32> elements)
        {
            var minimum = elements[0];

            if (elements.Count == 1)
            {
                return minimum;
            }
            else
            {
                var maximum = elements[1];

                var maximumDifference = maximum - minimum;

                for (var i = 2; i < elements.Count; i++)
                {
                    var element = elements[i];

                    if (minimum > element)
                    {
                        minimum = element;
                    }
                    if (maximum < element)
                    {
                        maximum = element;
                    }

                    maximumDifference = maximum - minimum;
                }

                return maximumDifference;
            }
           
        }

        public IReadOnlyList<Int32> Elements { get; }

        public Int32 MaximumDifference { get; }
    }

}
