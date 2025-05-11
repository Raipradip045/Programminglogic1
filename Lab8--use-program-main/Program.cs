// See https://aka.ms/new-console-template for more information
// Step 1
Using System;
class Animal
{
    public virtual void AnimalSound()// Virtual method
    {
        Console.WriteLine("The animal makes a sound");
    }
}
//Step 2
class Cat: Animal 
{
    public override void AnimalSound()
    {
        Console.WriteLine("The cat says:meow");
    }
}
class Dog: Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    })
}

//Step 3
class Program
{
    static void Main(string[]args)
    {
        Animal myAnimal;

        myAnimal = new Animal();
        myAnimal.AnimalSound();

        myAnimal = new Cat();
        myAnimal.AnimalSound();

        myAnimal = new Dog();
        myAnimal.AnimalSound();
    }
}



