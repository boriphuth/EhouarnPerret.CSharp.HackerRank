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
using System.Collections.Generic;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day18QueueAndStacks
{
	public class Palindrome
	{
        public Palindrome()
        {
            this.Queue = new Queue<Char>();
            this.Stack = new Stack<Char>();
        }

        private Queue<Char> Queue { get; }
        private Stack<Char> Stack { get; }

        public void PushCharacter(Char character)
        {
            this.Stack.Push(character);
        }

        public void EnqueueCharacter(Char character)
        {
            this.Queue.Enqueue(character);
        }

        public Char PopCharacter()
        {
            return this.Stack.Pop();
        }

        public Char DequeueCharacter()
        {
            return this.Queue.Dequeue();
        }
	}

}

