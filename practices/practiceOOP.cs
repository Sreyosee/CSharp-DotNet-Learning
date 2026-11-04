using System;

namespace practices
{
    // Parent class
    class Animal
    {
        protected string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        // Overloading
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");
        }

        // Allows child classes to override
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Inheritance
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        // Overriding
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }

    class practiceOOP
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy");
            Cat cat = new Cat("Mimi");

            Console.WriteLine("For Dog:");
            dog.Eat();
            dog.Eat("meat");

            Console.WriteLine("\nFor Cat:");

            cat.Eat();
            cat.Eat("Fish");

            Console.WriteLine("\nSounds:");

            Animal[] animals = { dog, cat };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}