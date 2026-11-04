using System;

namespace practices
{
    class practice2
    {
        static void Main(string[] args)
        {
            // User input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "";

            // Array
            int[] marks = new int[3];

            // for Loop 
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter mark for subject {i + 1}: ");

                bool isValid = int.TryParse(
                    Console.ReadLine(), out int mark);

                if (!isValid || mark < 0 || mark > 100)
                {
                    Console.WriteLine(
                        "Invalid mark. Enter a whole number from 0 to 100.");

                    i--; // Repeat this subject
                    continue;
                }

                marks[i] = mark;
            }

            // Calculate total using foreach
            int total = 0;

            foreach (int mark in marks)
            {
                total += mark;
            }

            double average = (double)total / marks.Length;

            string grade = GetGrade(average);

            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Grade: {grade}");
        }
        static string GetGrade(double average)
        {
            if (average >= 80)
            {
                return "A";
            }
            else if (average >= 60)
            {
                return "B";
            }
            else if (average >= 40)
            {
                return "C";
            }
            else
            {
                return "Fail";
            }
        }
    }
}