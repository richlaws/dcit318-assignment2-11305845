using System;

namespace InheritanceAndOverriding
{
    // Base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            Console.WriteLine("Animal sound:");
            myAnimal.MakeSound();   // Outputs: Some generic sound

            Console.WriteLine("Dog sound:");
            myDog.MakeSound();      // Outputs: Bark

            Console.WriteLine("Cat sound:");
            myCat.MakeSound();      // Outputs: Meow
        }
    }
}
