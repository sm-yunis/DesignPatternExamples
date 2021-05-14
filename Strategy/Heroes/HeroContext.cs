using System;

class HeroContext : IHero {

    private IHero _hero;

    public HeroContext(IHero hero) => _hero = hero;
   
    public void SetHero(IHero hero) => _hero = hero;
    public string GetCurrentHero() => _hero.ToString();

    public void Taunt() {
        _hero.Taunt();
    }

    public void Fight() {
        _hero.Fight();
    }

}