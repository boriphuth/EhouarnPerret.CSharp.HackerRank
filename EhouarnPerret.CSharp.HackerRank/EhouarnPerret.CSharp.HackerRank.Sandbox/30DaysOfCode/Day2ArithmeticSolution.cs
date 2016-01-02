// File: Day2Solution.cs
// Author: Ehouarn Perret
// Email: ehouarn.perret@art-logics.com
// Company: ART logics
// Website: http://www.art-logics.com
// Copyright: ART logics © All Rights Reserved.
using System;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode
{
    public static class Day2ArithmeticSolution
    {
        public static void Main(params String[] arguments)
        {
            // Original price
            var originalPrice = Convert.ToDouble(Console.ReadLine());

            // Original Price Off Percentage
            var originalPriceOffPercentage = Convert.ToInt32(Console.ReadLine());

            // Original Price Tax Percentage
            var originalPriceTaxPercentage = Convert.ToInt32(Console.ReadLine());

            // Tip 
            var tip = originalPrice * originalPriceOffPercentage / 100;

            // Tax
            var tax = originalPriceTaxPercentage * originalPrice / 100;

            var finalPrice = originalPrice + tip + tax;

            var mealFinalPrice = Math.Round(finalPrice);

            Console.WriteLine(@"The final price of the meal is $" + mealFinalPrice + ".");
        }
    }
}

