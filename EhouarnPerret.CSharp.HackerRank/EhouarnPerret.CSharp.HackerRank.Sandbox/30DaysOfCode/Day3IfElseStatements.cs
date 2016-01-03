// File: Day3IfElseStatements.cs
// Author: Ehouarn Perret
// Email: ehouarn.perret@art-logics.com
// Company: ART logics
// Website: http://www.art-logics.com
// Copyright: ART logics © All Rights Reserved.
using System;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode
{
    /// <summary>
    ///  A comprehensive soution
    /// </summary>
    public static class Day3IfElseStatementsSolution
    {
        public static void Main(params String[] arguments)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            if (n.IsNotBetween(1, 100))
            {
                return;
            }
            else
            {
                if (n.IsOdd())
                {
                    Console.WriteLine(@"Weird");
                }
                else // if (n.IsEven())
                {
                    if (n.IsBetween(2, 5))
                    {
                        Console.WriteLine(@"Not Weird");
                    }
                    else if (n.IsBetween(6, 20))
                    {
                        Console.WriteLine(@"Weird");
                    }
                    else // if (n.IsStrictlyGreaterThan(20))
                    {
                        Console.WriteLine(@"Not Weird");
                    }
                }
            }
        }
    }

    public static class Extensions
    {
        public static Boolean IsEven(this Int32 value)
        {
            return value % 2 == 0;
        }
        public static Boolean IsOdd(this Int32 value)
        {
            return value % 2 != 0;
        }

        public static Boolean IsBetween<T> (this T value, T lowerBound, T upperBound)
            where T : IComparable<T>
        {
            if (lowerBound.CompareTo(upperBound) > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(lowerBound));
            }
            else
            {
                return (lowerBound.CompareTo(value) <= 0) && (upperBound.CompareTo(value) >= 0);
            }


        }
    
        public static Boolean IsNotBetween<T> (this T value, T lowerBound, T upperBound)
            where T : IComparable<T>
        {
            if (lowerBound.CompareTo(upperBound) > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(lowerBound));
            }
            else
            {
                return (lowerBound.CompareTo(value) >= 0) && (upperBound.CompareTo(value) <= 0);
            }
        }

        public static Boolean IsStrictlyNotBetween<T> (this T value, T lowerBound, T upperBound)
            where T : IComparable<T>
        {
            if (lowerBound.CompareTo(upperBound) >= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(lowerBound));
            }
            else
            {
                return (lowerBound.CompareTo(value) > 0) && (upperBound.CompareTo(value) < 0);
            }
        }

        public static Boolean IsStrictlyGreaterThan<T>(this T value, T otherValue)
            where T : IComparable<T>
        {
            return value.CompareTo(otherValue) > 0;
        }
    }
}

