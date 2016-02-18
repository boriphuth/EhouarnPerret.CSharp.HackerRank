//
// Person.cs
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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day4BooleanOperatorsClassVsInstance
{
    public class Person 
    {
        public Int32 Age { get; private set; }

        public Person(Int32 age)
        {
            if (age < 0)
            {
                Console.WriteLine(@"This person is not valid, setting age to 0.");
                this.Age = 0;
            }
            else
            {
                this.Age = age;
            }
            // Add some more code to run some checks on initial_AgeOfPerson
        }
        public void amIOld() 
        {
            // Do some computations in here and print out the correct statement to the console
            if (this.Age < 13)
            {
                Console.WriteLine(@"You are young.");
            }
            else if ((this.Age >= 13) && (this.Age < 18))
            {
                Console.WriteLine(@"You are a teenager.");
            }
            else if (this.Age >= 18)
            {
                Console.WriteLine(@"You are old.");
            }
        }

        // Aw please HackerRank follow the MS guidelines... about naming
        public void yearPasses()
        {
            // Increment the age of the person in here
            this.Age++;
        }
    }
}
