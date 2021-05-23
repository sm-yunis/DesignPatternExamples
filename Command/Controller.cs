class Controller {
    private IPersonCommand _command;

    public void SetCommand(IPersonCommand command){
        _command = command;
    }

    public void Invoke(){
        _command.Execute();
    }

}