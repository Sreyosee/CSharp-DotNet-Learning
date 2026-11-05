// LINQ Projection Example
using System;
using System.Linq;

namespace practices
{
    class Projection
    {
        static void Main()
        {
   
            int[] marks = { 45, 80, 60, 30 };

            foreach (int mark in marks)
            {
                Console.WriteLine("Mark without bonus: {0}", mark);
            }

            var marksWithBonus = marks.Select(mark => mark + 5);

            foreach (int mark in marksWithBonus)
            {
                Console.WriteLine("Mark with bonus: {0}", mark);
            }
        }
    }
}