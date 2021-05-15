
class Fight : IHeroAction
{
    private string _fightingStyle;
    public Fight(string fightingStyle)
    {
        this._fightingStyle = fightingStyle;
    }

    public void DoHeroAction()
    {
        System.Console.WriteLine(_fightingStyle);
    }
}