
class Person : IPerson
{
    private readonly string _name;
    private readonly int _age;

    public string Name => _name;
    public int Age => _age;

    public Person(string name, int age)
    {
        (_name, _age) = (name, age);
    }

    public void Eat()
    {
        System.Console.WriteLine($"{_name} is Eating");
    }

    public void Read()
    {
        System.Console.WriteLine($"{_name} is Reading");
    }

    public void Shit()
    {
        System.Console.WriteLine($"{_name} is Shiting");
    }

    public void Sleep()
    {
        System.Console.WriteLine($"{_name} is Sleeping");
    }

    public void Speak()
    {
        System.Console.WriteLine($"{_name} is Speaking");
    }

    public void WakeUp()
    {
        System.Console.WriteLine($"{_name} is Waking Up");
    }

    public void Work()
    {
        System.Console.WriteLine($"{_name} is Working");
    }
}