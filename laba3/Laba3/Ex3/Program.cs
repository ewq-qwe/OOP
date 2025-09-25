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
    { }
    public Person(int age) : this("No name", age)
    { }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    class Family
    {
        private List<Person> members;
        public Family()
        {
            members=new List<Person>();
        }
        public void AddMember(Person p)
        {
            members.Add(p);
        }
        public Person OldMember()
        {
            return members.OrderByDescending(p=>p.Age).FirstOrDefault();
        }
    }
    class Program
    {
        static void Main()
        {
            int n= int.Parse(Console.ReadLine());
            Family family=new Family();
            for(int i=0;i<n;i++)
            {
                string[] input=Console.ReadLine().Split();
                string name=input[0];
                int age=int.Parse(input[1]);
                Person person=new Person(name,age);
                family.AddMember(person);
            }
            Person oldest=family.OldMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }

}
