using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = HeroContextFactory.CreateHeroContext(Hero.Batman);
            hero.Taunt();
            hero.Fight();
            
        }
    }
}
