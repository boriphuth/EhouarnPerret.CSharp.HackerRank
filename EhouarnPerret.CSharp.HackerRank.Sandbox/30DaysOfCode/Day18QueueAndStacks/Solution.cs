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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day18QueueAndStacks
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            // Read a word.
            var word = Console.ReadLine();

            // Create the Palindrome class object palindrome.
            var palindrome = new Palindrome();

            // Push all the characters of the word to the Stack.
            foreach (var character in word)
            {
                palindrome.PushCharacter(character);
            }

            // Enqueue all the characters of the word to the Queue.
            foreach (var character in word) 
            {
                palindrome.EnqueueCharacter(character);
            }

            var isPalindrome = true;

            // Pop the top character from stack.
            // Dequeue the first character from queue.
            // Compare both characters.
            for (var i = 0; i < word.Length; i++) 
            {
                if (palindrome.PopCharacter() != palindrome.DequeueCharacter()) 
                {
                    isPalindrome = false;

                    break;
                }
            }

            // Finally print whether the word is a palindrome or not.
            if (isPalindrome) 
            {
                Console.Write("The word, {0}, is a palindrome.", word);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", word);
            }
        }
    }
}

