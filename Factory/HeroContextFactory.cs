using Strategy;
using Strategy.SuperHeroes;

namespace Factory
{

    enum Hero
    {
        Batman, Thor, SpiderMan
    }


    static class HeroContextFactory
    {

        public static IHeroContext CreateHeroContext(string heroName)
        {
            return heroName switch
            {
                "Batman" => new HeroContext<Batman>(),
                "Thor" => new HeroContext<Thor>(),
                "SpiderMan" => new HeroContext<SpiderMan>(),
                _ => null
            };
        }

        public static IHeroContext CreateHeroContext(Hero heroName)
        {
            return heroName switch
            {
                Hero.Batman => new HeroContext<Batman>(),
                Hero.Thor => new HeroContext<Thor>(),
                Hero.SpiderMan => new HeroContext<SpiderMan>(),
                _ => null
            };
        }

    }


}