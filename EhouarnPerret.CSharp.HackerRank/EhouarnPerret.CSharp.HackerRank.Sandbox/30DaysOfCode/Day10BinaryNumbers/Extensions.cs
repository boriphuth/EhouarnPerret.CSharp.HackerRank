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
using System.Security.Cryptography.X509Certificates;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day10BinaryNumbers
{

    public static class Extensions
    {
        public static String ToBinaryString(this UInt32 n, Boolean isUsingZeroPadding = false)
        {
            var bits = new Char[32];

            if (!isUsingZeroPadding)
            {
                var i = 0;

                while(n != 0)
                {
                    bits[31 - i] = (n & 1) == 0 ? '0' : '1';
                    n >>= 1;
                    i++;
                }

                return new String(bits, 32 - i, i);
            }
            else
            {
                for (int i = 0; i < 32; i++)
                {
                    if (n != 0)
                    {
                        bits[31 - i] = (n & 1) == 0 ? '0' : '1';
                        n >>= 1;
                    }
                    else
                    {
                        bits[31 - i] = '0';
                    }
                }

                return new String(bits);
            }
        }
    }
}
