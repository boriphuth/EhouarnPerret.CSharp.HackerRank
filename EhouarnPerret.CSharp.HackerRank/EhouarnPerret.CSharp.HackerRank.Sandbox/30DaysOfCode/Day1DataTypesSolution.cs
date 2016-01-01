// File: Day1DataTypes.cs
// Author: Ehouarn Perret
// Email: ehouarn.perret@art-logics.com
// Company: ART logics
// Website: http://www.art-logics.com
// Copyright: ART logics © All Rights Reserved.
using System;

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode
{
    /// <summary>
    /// The code below stinks but it is accepted seriously HackerRank...
    /// </summary>
    public static class Day1DataTypesSolution
    {
        public static void Main(params String[] arguments)
        {
            var values = new Object[]
            {
                5.35,
                'a',
                false,
                100,
                "I am a code monkey",
                true,
                17.3,
                'c',
                "derp",
            };

            foreach(var value in values)
            {
                var valueType = value.GetType();
                var valueTypeCategory = valueType.IsPrimitive ? @"Primitive" : "Referenced";

                var valueTypeName = String.Empty;

                if (valueType.Name == @"Char")
                {
                    valueTypeName = @"Character";
                }
                else if (valueType.Name.Contains(@"Int")) 
                {
                    valueTypeName = @"Integer";
                }
                else
                {
                    valueTypeName = valueType.Name;
                }

                Console.WriteLine(valueTypeCategory + " : " + valueTypeName);
            }
        }
    }
}

