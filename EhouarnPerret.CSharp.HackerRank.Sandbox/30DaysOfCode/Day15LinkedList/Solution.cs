﻿//
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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day15LinkedList
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var head = default(LinkedListNode<Int32>);

            var testCaseCount = Int32.Parse(Console.ReadLine());

            while (testCaseCount-- > 0)
            {
                var data = Int32.Parse(Console.ReadLine());
                head = Solution.Insert(head,data);
            }

            Solution.Display(head);
        }

        public static LinkedListNode<TValue> Insert<TValue>(LinkedListNode<TValue> head, TValue value)
        {
            if (head == null)
            {
                head = new LinkedListNode<TValue>(value);

                return head;
            }
            else
            {
                var currentNode = head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = new LinkedListNode<TValue>(value);

                return head;
            }
        }

        public static void Display<TValue>(LinkedListNode<TValue> head)
        {
            var currentNode = head;

            while(currentNode != null)
            {
                Console.Write(currentNode.Value + @" ");

                currentNode = currentNode.Next;
            }
        }
    }
}

