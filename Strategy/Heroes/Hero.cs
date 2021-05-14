
abstract class Hero {

    private IHeroAction _heroAction;

    public void SetHeroAction(IHeroAction heroAction) => _heroAction = heroAction;

    public void DoHeroStuff(){
        _heroAction.DoHeroStuff();
    }

}