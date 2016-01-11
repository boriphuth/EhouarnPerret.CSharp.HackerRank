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
using System.ComponentModel;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge9CaesarCipher
{
    public static class Solution
    {
        public static void Main(params String[] args)
        {
            var stringLength = Convert.ToByte(Console.ReadLine());

            var uncypheredString = Console.ReadLine().Substring(0, stringLength);

            var rotationPerLetterCount = Convert.ToByte(Console.ReadLine());

            var encypheredStringCharacters = new Char[stringLength];


            for (var i = 0; i < stringLength; i++)
            {
                if (Char.IsLetter(uncypheredString[i]))
                {
                    var characterByte = (Byte)uncypheredString[i];

                    var startByte = (Byte)(Char.IsUpper(uncypheredString[i]) ? 'A' : 'a');

                    encypheredStringCharacters[i] = (Char)(Byte)(startByte + (characterByte - startByte + rotationPerLetterCount) % 26);
                }
                else
                {
                    encypheredStringCharacters[i] = uncypheredString[i];
                }
            }

            var encypheredString = new String(encypheredStringCharacters);

            Console.WriteLine(encypheredString);
        }
    }
}

