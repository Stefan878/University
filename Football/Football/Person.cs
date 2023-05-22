using System.Net.Cache;

namespace Football
{
    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void ShowAge()
        {
            Console.WriteLine($"The {Name} is {Age} years old");
        }
    }

    
}
