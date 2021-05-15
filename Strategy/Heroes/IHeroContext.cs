namespace Strategy
{
    public interface IHeroContext : IHero
    {

        public void SetHero(IHero hero);
        public void SetHero<TNewHero>() where TNewHero : IHero, new();
        public string GetCurrentHero();

    }
}