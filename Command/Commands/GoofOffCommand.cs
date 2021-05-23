class GoofOffCommand : IPersonCommand
{
    private readonly IPerson _person;

    public GoofOffCommand(IPerson person)
    {
        _person = person;
    }
    public void Execute()
    {
        _person.WakeUp();
        _person.Eat();
        _person.Shit();
        _person.Sleep();
        _person.Sleep();
        _person.Sleep();
        _person.Eat();
        _person.Shit();
        _person.Sleep();
    }
}