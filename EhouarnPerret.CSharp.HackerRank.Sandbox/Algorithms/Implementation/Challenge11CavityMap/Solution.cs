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
using System.Text;
using System.Collections;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Implementation.Challenge11CavityMap
{
    public static class Solution
    {
        public static void Main(params String[] arguments)
        {
            var gridSize = Convert.ToByte(Console.ReadLine());

            var grid = new Char[gridSize, gridSize];

            for(var gridRowIndex = 0; gridRowIndex < gridSize; gridRowIndex++)
            {
                var gridRow = Console.ReadLine().Substring(0, gridSize);

                for (var gridColumnIndex = 0; gridColumnIndex < gridSize; gridColumnIndex++)
                {
                    grid[gridRowIndex, gridColumnIndex] = gridRow[gridColumnIndex];   
                }
            }

            grid.MarkGridCavities();

            var stringBuilder = new StringBuilder();

            for(var gridRowIndex = 0; gridRowIndex < gridSize; gridRowIndex++)
            {
                for (var gridColumnIndex = 0; gridColumnIndex < gridSize; gridColumnIndex++)
                {
                    stringBuilder.Append(grid[gridRowIndex, gridColumnIndex]);
                }

                stringBuilder.Append(Environment.NewLine);
            }

            Console.Write(stringBuilder.ToString());
        }
    }

    public static class ArrayExtensions
    {
        public static void MarkGridCavities(this Char[,] grid)
        {
            var gridWidth = grid.GetLength(0);
            var gridHeight = grid.GetLength(1);

            if (gridWidth != gridHeight)
            {
                throw new ArgumentOutOfRangeException(nameof(grid));
            }
            else
            {
                var gridSize = gridWidth;

                for (var gridRowIndex = 1; gridRowIndex <= (gridSize - 2); gridRowIndex++)
                {
                    for (var gridColumnIndex = 1; gridColumnIndex <= (gridSize - 2); gridColumnIndex++)
                    {
                        var north = grid[gridRowIndex - 1, gridColumnIndex];
                        var south = grid[gridRowIndex + 1, gridColumnIndex];
                        var west  = grid[gridRowIndex, gridColumnIndex - 1];
                        var east  = grid[gridRowIndex, gridColumnIndex + 1];

                        var center =  grid[gridRowIndex, gridColumnIndex];

                        if ((north.CompareTo(center) < 0) && (south.CompareTo(center) < 0) && (west.CompareTo(center) < 0) && (east.CompareTo(center) < 0))
                        {
                            grid[gridRowIndex, gridColumnIndex] = 'X';
                        }
                    }
                }
            }
        }
    }
}

