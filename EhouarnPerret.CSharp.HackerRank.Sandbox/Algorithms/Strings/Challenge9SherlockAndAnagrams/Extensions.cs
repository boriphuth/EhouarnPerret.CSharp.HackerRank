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
using System.Security.Policy;
using System.Collections.Generic;
using System.Linq;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Strings.Challenge9SherlockAndAnagrams
{
    public static class Extensions
    {
        public static String Sort(this String value)
        {
            var characters = value.ToCharArray();

            Array.Sort(characters);

            return new String(characters);
        }

        public static IEnumerable<String> ToSubstrings(this String value)
        {
            for (var length = 1; length < value.Length; length++)
            {
                for (var start = 0; start <= (value.Length - length); start++)
                {
                    yield return value.Substring(start, length);
                }
            }
        }
    
        public static UInt32 CountSubstringAnagramPairs(this String value)
        {
            var dictionary = new Dictionary<String, UInt32>();

            var wordSubstrings = value.ToSubstrings();

            // Everytime we have a new substring which pairs with an already found one
            // We add 1 to the counter for that substring
            foreach (var wordSubstring in wordSubstrings)
            {
                var sortedWordSubstring = wordSubstring.Sort();

                if  (dictionary.ContainsKey(sortedWordSubstring))
                {
                    dictionary[sortedWordSubstring]++;
                }
                else
                {
                    dictionary.Add(sortedWordSubstring, 1);
                }
            }

            var anagramPairCount = 0u;

            // Each substring can be combined with all the previous found ones! 
            // Every combination: n pairable substrings => there are then:
            // (n - 1) + ... + 1 = n * (n - 1) / 2 possible pairs between them
            foreach (var occurenceCount in dictionary.Values) 
            {
                // At least 2 occurences of the same set of characters means there is a pair of anagram
                if (occurenceCount >= 2) 
                {
                    anagramPairCount += (occurenceCount * (occurenceCount - 1)) / 2;
                }
            } 

            return anagramPairCount;
        }
    }
}
