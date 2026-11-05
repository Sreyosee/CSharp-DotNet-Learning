using System;

namespace StudyTaskManager
{
    class StudyTask
    {
        public string Title { get; }
        public bool IsCompleted { get; private set; }

        public StudyTask(string title)
        {
            Title = title;
            IsCompleted = false;
        }

        public void MarkComplete()
        {
            IsCompleted = true;
        }

        public void ShowDetails()
        {
            string status = IsCompleted ? "Completed" : "Pending";
            Console.WriteLine($"{Title} - {status}");
        }
    }

    class Program
    {
        static void Main()
        {
            StudyTask task1 = new StudyTask("Read C# notes");
            StudyTask task2 = new StudyTask("Practise inheritance");
            StudyTask task3 = new StudyTask("Review polymorphism");

            task1.MarkComplete();

            task1.ShowDetails();
            task2.ShowDetails();
            task3.ShowDetails();
        }
    }
}