using System;

//Завдання1
using System;


public abstract class Figure
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

public class Circle : Figure
{

    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}
//Завдання 2
public class Fruit
{
    public string Name { get; set; }

    public Fruit(string name)
    {
        Name = name;
    }
}

public class Apple : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }

    public Apple(string name, string variety, string color) : base(name)
    {
        Variety = variety;
        Color = color;
    }
}

public class Pear : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }

    public Pear(string name, string variety, string color) : base(name)
    {
        Variety = variety;
        Color = color;
    }
}

public abstract class Animal
{
    public float Weight { get; set; }
    public string Color { get; set; }

    public Animal(string color, float weight)
    {
        Color = color;
        Weight = weight;
    }

    public abstract string MakeSound();
}
//Завдання 3
public abstract class AnimalWithTail : Animal
{
    public float TailLength { get; set; }

    public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
    {
        TailLength = tailLength;
    }
}

public class Cat : AnimalWithTail
{
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    private string Purr() => "purrrrrrrr";
    private string Meow() => "Meow";

    public override string MakeSound() => Purr() + " " + Meow();

    public override string ToString() => $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
}

public class Dog : AnimalWithTail
{
    public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    public override string MakeSound() => "Woof";

    public override string ToString() => $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";

}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(8);
        Console.WriteLine($"Площа кола: {circle.CalculateArea()}");
        Console.WriteLine($"Периметр кола: {circle.CalculatePerimeter()}");

        Rectangle rectangle = new Rectangle(1, 15);
        Console.WriteLine($"Площа прямокутника: {rectangle.CalculateArea()}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.CalculatePerimeter()}");

        Fruit fruit = new Fruit("Фрукт");

        Apple apple = new Apple("Яблуко", "Чемпіон", "Зелений");
        Console.WriteLine($"Назва: {apple.Name}, Сорт: {apple.Variety}, Колір: {apple.Color}");

        Pear pear = new Pear("Груша", "Бера", "Жовтий");
        Console.WriteLine($"Назва: {pear.Name}, Сорт: {pear.Variety}, Колір: {pear.Color}");

        Cat cat = new Cat("White", 5f, 14.8f);
        Console.WriteLine(cat.MakeSound());
        Console.WriteLine(cat.ToString());

        Dog dog = new Dog("Brown", 11f, 25f);
        Console.WriteLine(dog.MakeSound());
        Console.WriteLine(dog.ToString());
    }
}


