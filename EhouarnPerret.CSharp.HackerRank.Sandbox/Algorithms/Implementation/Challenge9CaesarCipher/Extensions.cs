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
using System.Text;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge9CaesarCipher
{

    public static class Extensions
    {
        private static Byte LatinAlphabetCharacterCount { get; } = 26;
        private static Byte LowerCaseAASCIIByte { get; } = 'a'.ToASCIIByte();
        private static Byte LowerCaseZASCIIByte { get; } = 'z'.ToASCIIByte(); // 'a' byte + 25 (26 - 1)
        private static Byte UpperCaseAASCIIByte { get; } = 'A'.ToASCIIByte();
        private static Byte UpperCaseZASCIIByte { get; } = 'Z'.ToASCIIByte(); // 'A' byte + 25 (26 - 1)

        public static Char ToASCIIChar(this Byte value)
        {
            return Encoding.ASCII.GetChars(new Byte[1] { value } )[0];
        }
        public static Byte ToASCIIByte(this Char value)
        {
            return Encoding.ASCII.GetBytes(new Char[1] { value } )[0];
        }

        public static String CaesarEncypher(this String value, Byte rotationPerLetterCount)
        {
            var encypheredCharacters = new Char[value.Length];

            for (var i = 0; i < value.Length; i++)
            {
                var uncypheredCharacter = value[i];

                if (Char.IsLetter(uncypheredCharacter))
                {
                    var asciiByte = uncypheredCharacter.ToASCIIByte();

                    encypheredCharacters[i] = Char.IsLower(uncypheredCharacter) ? 
                        asciiByte.Modulo(rotationPerLetterCount, Extensions.LowerCaseAASCIIByte, Extensions.LowerCaseZASCIIByte).ToASCIIChar() : 
                        asciiByte.Modulo(rotationPerLetterCount, Extensions.UpperCaseAASCIIByte, Extensions.UpperCaseZASCIIByte).ToASCIIChar();
                }
                else
                {
                    encypheredCharacters[i] = uncypheredCharacter;
                }
            }

            return new String(encypheredCharacters);
        }
    
        public static Byte Modulo(this Byte value, Byte rightShiftCount, Byte start, Byte stop)
        {
            if (start > stop)
            {
                throw new ArgumentOutOfRangeException(nameof(start));
            }
            else if (!((start <= value ) && (value <= stop)))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            else
            {
                return Convert.ToByte((rightShiftCount + value - start) % (1 + stop - start) + start); 
            }
        }
    }
}
