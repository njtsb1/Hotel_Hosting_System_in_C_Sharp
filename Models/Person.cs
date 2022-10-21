namespace ChallengeProjectHosting.Models;

public class Person
{
    public Person() { }

    public Person(string name)
    {
        Name = name;
    }

    public Person(string name, string lastname)
    {
        Name = name;
        Lastname = lastname;
    }

    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Fullname => $"{Name} {Lastname}".ToUpper();
}