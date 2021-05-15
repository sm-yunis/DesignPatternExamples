
namespace Strategy
{

    public class HeroContext<THero> : IHero, IHeroContext
            where THero : IHero, new()
    {

        private IHero _hero;

        public HeroContext() => _hero = new THero();

        public void SetHero(IHero hero) => _hero = hero;
        public void SetHero<TNewHero>() where TNewHero : IHero, new() => _hero = new TNewHero();

        public string GetCurrentHero() => _hero.ToString();

        public void Taunt()
        {
            _hero.Taunt();
        }

        public void Fight()
        {
            _hero.Fight();
        }

    }
}