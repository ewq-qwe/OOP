using System;
class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person() : this("No name", 1)
    {
    }
    public Person(int age) : this("No name", age)
    {
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    /*public Person()
    {
        name = "Unknown";
        age = 0;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }*/

    class Program
    {
        static void Main()
        {
            Person s1 = new Person("Ivan", 20);
            Person s2 = new Person(25);
            Person s3 = new Person();
            
            Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}");
            Console.WriteLine($"Name: {s2.Name}, Age: {s2.Age}");
            Console.WriteLine($"Name: {s3.Name}, Age: {s3.Age}");

        }
    }
}