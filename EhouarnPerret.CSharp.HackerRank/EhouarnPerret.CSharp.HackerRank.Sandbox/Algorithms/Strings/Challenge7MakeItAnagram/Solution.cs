//
// MakeItAnagram.cs
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
using System.Text;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Strings.Challenge7MakeItAnagram
{
    public static class Solution
    {
        // Can make it faster playing with ASCII and cheap arrays
        // Make it a bit verbose for the sake of understanding...
        public static void Main(params String[] arguments)
        {
            // Getting inputs
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            const Int32 latinAlphabetCharacterCount = 26;

            var aCharacterCount = new Int32[latinAlphabetCharacterCount];
            var bCharacterCount = new Int32[latinAlphabetCharacterCount];
            var firstASCIILetterIndex = Encoding.ASCII.GetBytes(new Char[] { 'a' })[0];

            foreach (var character in a)
            {
                aCharacterCount[character - firstASCIILetterIndex]++;
            }
            foreach (var character in b)
            {
                bCharacterCount[character - firstASCIILetterIndex]++;
            }

            var minimumDeletionCount = 0;

            for (var i = 0; i < latinAlphabetCharacterCount; i++)
            {
                minimumDeletionCount += Math.Abs(aCharacterCount[i] - bCharacterCount[i]);
            }

            Console.WriteLine(minimumDeletionCount);
        }
    }
}

