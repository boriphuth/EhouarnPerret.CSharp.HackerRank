//
// LinkedListNode.cs
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
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day24MoreReviewMoreLinkedLists
{
    public class LinkedListNode<T>
    {
        public T Value { get; }

        public LinkedListNode<T> Next { get; internal set; }

        public LinkedListNode(T value)
        {
            this.Value = value;
        }

        public void WriteFollowingNodesLineToConsole()
        {
            var current = this;

            var stringBuilder = new StringBuilder();

            while(current!= null)
            {
                stringBuilder.Append(current.Value);

                stringBuilder.Append(' ');

                current = current.Next;
            }

            Console.WriteLine(stringBuilder);
        }

        public LinkedListNode<T> TailNode
        {
            get
            {
                var current = this;

                while(current.Next != null)
                {
                    current = current.Next;
                }

                return current;
            }
        }

        public static LinkedListNode<T> RemoveCurrent(LinkedListNode<T> previousNode)
        {
            if (previousNode == null)
            {
                throw new ArgumentNullException(nameof(previousNode));
            }
            // Current
            else if (previousNode.Next == null)
            {
                return null;
            }
            else
            {
                var currentNodeNext = previousNode.Next.Next;

                previousNode.Next = null;

                previousNode.Next = currentNodeNext;

                return currentNodeNext;
            }
        }

        public void RemoveDuplicates()
        {
            var hashSet = new HashSet<T>();

            var previous = default(LinkedListNode<T>);

            var current = this;

            while (current != null)
            {
                if (!hashSet.Add(current.Value))
                {
                    current = RemoveCurrent(previous);
                }
                else
                {
                    previous = current;

                    current = current.Next;
                }
            }
        }

        public override String ToString()
        {
            return this.Value.ToString();
        }

        public static LinkedListNode<T> TailInsert(LinkedListNode<T> headNode, T value)
        {
            var tailLinkedListNode = new LinkedListNode<T>(value);

            if (headNode == null)
            {
                headNode = tailLinkedListNode;

                return headNode;
            }
            else
            {
                headNode.TailNode.Next = tailLinkedListNode;

                return headNode;
            }
        }
    }
}
