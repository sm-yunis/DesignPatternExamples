using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new HeroContext<Thor>();
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
