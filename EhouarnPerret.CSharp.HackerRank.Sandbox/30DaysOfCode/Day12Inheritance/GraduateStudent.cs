//
// Grade.cs
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

namespace EhouarnPerret.CSharp.HackerRank.Sandbox.DaysOfCode.Day12Inheritance
{
    public class GraduateStudent : Student
    {
        private Int32 _score;
        public Int32 Score => this._score;

        public GraduateStudent(String firstName, String lastName, UInt32 phone, Int32 score)
            : base(firstName, lastName, phone)
        {
            this._score = score;
        }

        public StudentGrade Grade
        {
            get
            {
                if (this._score < (Byte)StudentGrade.D)
                {
                    return StudentGrade.D;
                }
                else if (((Byte)StudentGrade.D <= this._score) && (this._score < (Byte)StudentGrade.B))
                {
                    return StudentGrade.B;
                }
                else if (((Byte)StudentGrade.B <= this._score) && (this._score < (Byte)StudentGrade.A))
                {
                    return StudentGrade.A;
                }
                else if (((Byte)StudentGrade.A <= this._score) && (this._score < (Byte)StudentGrade.E))
                {
                    return StudentGrade.E;
                }
                else // if (((Byte)StudentGrade.E <= this._score) && (this._score <= (Byte)StudentGrade.O))
                {
                    return StudentGrade.O;
                }
            }
        }
    }
}
