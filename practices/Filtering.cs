// LINQ Filtering Example
using System;
using System.Linq;

namespace practices
{
    class Filtering
    {
        static void Main()
        {
            int[] marks = { 45, 80, 60, 30 };

            var passingMarks = marks.Where(mark => mark >= 60);

            foreach (int mark in passingMarks)
            {
                Console.WriteLine("Passing mark: {0}", mark);
            }
        }
    }
}