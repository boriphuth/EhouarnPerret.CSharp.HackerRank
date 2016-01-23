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
using System.Security.Cryptography.X509Certificates;
using System.CodeDom;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day23BinaryTreeReview
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var binaryTreeNode = default(BinaryTreeNode<Int32>);

            var testCaseCount = Int32.Parse(Console.ReadLine());

            for (var testCase = 0; testCase < testCaseCount; testCase++)
            {
                var data = Int32.Parse(Console.ReadLine());
                binaryTreeNode = Solution.BinarySearchTreeInsert(binaryTreeNode,data);            
            }
        }

        // Left Node should contains a value which is greater than the value contained in the right node.
        public static BinaryTreeNode<T> BinarySearchTreeInsert<T>(BinaryTreeNode<T> node, T value)
        {
            var comparer = Comparer<T>.Default;

            if(node == null)
            {
                return new BinaryTreeNode<T>(value);
            }
            else
            {
                var current = new BinaryTreeNode<T>(value);

                if(comparer.Compare(value, node.Value) <= 0)
                {
                    current = Solution.BinarySearchTreeInsert(node.Left, value);
                    node.Left = current;
                }
                else
                {
                    current = Solution.BinarySearchTreeInsert(node.Right, value);
                    node.Right = current;
                }

                return node;
            }
        }

        public static void LeverOrderTraversal<T>(BinaryTreeNode<T> root)
        {
            var queue = new Queue<BinaryTreeNode<T>>();

            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();

                Console.Write(node.Value + " ");

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);   
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
}

