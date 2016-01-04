// File: SimpleArraySum.cs
// Author: Ehouarn Perret
// Email: ehouarn.perret@art-logics.com
// Company: ART logics
// Website: http://www.art-logics.com
// Copyright: ART logics © All Rights Reserved.
using System;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.Algorithms.Warmup.Challenge0SolveMeFirst
{
    public static class Solution 
    {
        private static Int32 SolveMeFirst(Int32 a, Int32 b) 
        { 
            return a + b;
        }

        public static void Main(params String[] arguments) 
        {
            var a = Convert.ToInt32(Console.ReadLine());

            var b = Convert.ToInt32(Console.ReadLine());

            // Amazingly stupid
            var sum = Solution.SolveMeFirst(a, b);

            Console.WriteLine(sum);
        }
    }    
}

