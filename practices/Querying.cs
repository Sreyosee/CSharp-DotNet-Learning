// LINQ Querying Example
using System;
using System.Linq;

namespace practices
{
    class querying
    {
        static void Main()
        {
            int[] marks = { 45, 80, 60, 30 };

            var result =
                from mark in marks
                where mark >= 60
                orderby mark
                select mark;

            foreach (int mark in result)
            {
                Console.WriteLine("Mark greater than or equal to 60: {0}", mark);
            }
        }
    }
}