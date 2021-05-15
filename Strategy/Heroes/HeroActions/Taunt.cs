class Taunt : IHeroAction
{
    private string _tauntingWords;
    public Taunt(string tauntingWords)
    {
        _tauntingWords = tauntingWords; 
    }
    
    public void DoHeroAction()
    {
        System.Console.WriteLine(_tauntingWords);
    }
}