
abstract class Hero : IHero {

    private IHeroAction _heroAction;

    public void SetHeroAction(IHeroAction heroAction) => _heroAction = heroAction;

    public void DoHeroAction(){
        _heroAction.DoHeroAction();
    }

}