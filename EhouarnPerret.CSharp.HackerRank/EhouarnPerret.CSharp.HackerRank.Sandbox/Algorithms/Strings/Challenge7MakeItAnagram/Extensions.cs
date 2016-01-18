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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Strings.Challenge7MakeItAnagram
{

    public static class Extensions
    {
        public static Dictionary<Char, Int32> CharacterCount (this String value)
        {
            return value
                .GroupBy(character => character)
                .ToDictionary(item => item.Key, item => item.Count());
        }
        public static Dictionary<Char, Int32> OrderedCharacterCount (this String value)
        {
            return value
                .GroupBy(character => character)
                .OrderBy(item => item.Key)
                .ToDictionary(item => item.Key, item => item.Count());
        }

        public static Dictionary<Char, Int32> CharacterCount (this String value, IEnumerable<Char> symbols)
        {
            var characterCount = symbols.ToDictionary(character => character, character => 0);

            foreach (var character in value)
            {
                characterCount[character]++;
            }

            return characterCount;
        }
        public static Dictionary<Char, Int32> OrderedCharacterCount (this String value, IEnumerable<Char> symbols)
        {
            var characterCount = symbols
                .OrderBy(symbol => symbol)
                .ToDictionary(character => character, character => 0);

            foreach (var character in value)
            {
                characterCount[character]++;
            }

            return characterCount;
        }
        public static ReadOnlyDictionary<Char, Int32> ReadOnlyCharacterCount (this String value, IEnumerable<Char> symbols)
        {
            return value.CharacterCount(symbols).AsReadOnly();
        }

        public static ReadOnlyDictionary<Char, Int32> ReadOnlyOrderedCharacterCount (this String value, IEnumerable<Char> symbols)
        {
            return value.CharacterCount(symbols).AsReadOnly();
        }

        public static ReadOnlyDictionary<Char, Int32> ReadOnlyCharacterCount (this String value)
        {
            return value
                .CharacterCount()
                .AsReadOnly();
        }
        public static ReadOnlyDictionary<Char, Int32> ReadOnlyOrderedCharacterCount (this String value)
        {
            return value
                .OrderedCharacterCount()
                .AsReadOnly();
        }

        public static ReadOnlyDictionary<TKey, TValue> AsReadOnly <TKey, TValue> (this IDictionary<TKey, TValue> source)
        {
            return new ReadOnlyDictionary<TKey, TValue>(source);
        }
    }
}
