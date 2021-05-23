class BeProductiveCommand : IPersonCommand {

    private readonly IPerson _person;

    public BeProductiveCommand(IPerson person)
    {
        _person = person;
    }

    public void Execute()
    {
        _person.WakeUp();
        _person.Eat();
        _person.Work();
        _person.Read();
        _person.Sleep();
    }
}