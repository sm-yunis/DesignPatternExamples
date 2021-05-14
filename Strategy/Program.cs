using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroContext hero = HeroFactory.HeroContextFactory(Hero.Thor);
            hero.Taunt();
            hero.Fight();

            hero.SetHero(HeroFactory.HeroContextFactory(Hero.Batman));
            hero.Taunt();
            hero.Fight();

            hero.SetHero(HeroFactory.HeroContextFactory(Hero.SpiderMan));
            hero.Taunt();
            hero.Fight();

        }
    }
}
