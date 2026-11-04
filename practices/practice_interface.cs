using System;

namespace practices
{
    interface IPayable
    {
        decimal CalculatePay();
    }

    abstract class Employee
    {
        public string Name { get; set; }

        protected Employee(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine($"Employee: {Name}");
        }

        public abstract void Work();
    }

    class Developer : Employee, IPayable
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Developer writes code.");
        }

        public decimal CalculatePay()
        {
            return 50000m;
        }
    }

    class Teacher : Employee, IPayable
    {
        public Teacher(string name) : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Teacher teaches students.");
        }

        public decimal CalculatePay()
        {
            return 30000m;
        }
    }

    class practice_interface
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Prapti");
            Teacher teacher = new Teacher("Sara");

            Employee[] employees = { developer, teacher };

            foreach (Employee employee in employees)
            {
                employee.ShowName();
                employee.Work();
            }

            Console.WriteLine("\nPayments:");

            IPayable[] payables = { developer, teacher };

            foreach (IPayable payable in payables)
            {
                Console.WriteLine($"Pay: {payable.CalculatePay()}");
            }

        }
    }
}