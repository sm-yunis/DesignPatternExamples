using Strategy.SuperHeroes;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Various ways to create the same HeroContext
            IHeroContext heroContext1 = new HeroContext<Thor>();

            var hero = heroContext1;

            hero.Taunt();
            hero.Fight();

            hero.SetHero<Batman>();
            hero.Taunt();
            hero.Fight();

            hero.SetHero(new SpiderMan());
            hero.Taunt();
            hero.Fight();

        }
    }
}
