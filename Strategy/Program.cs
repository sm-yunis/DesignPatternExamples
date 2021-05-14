using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Batman bruceWayne = new Batman();
            HeroContext heroContext = new HeroContext(bruceWayne);

            System.Console.WriteLine(heroContext.GetCurrentHero());
            heroContext.Taunt();
            heroContext.Fight();

            heroContext.SetHero(new Thor());

            System.Console.WriteLine(heroContext.GetCurrentHero());
            heroContext.Taunt();
            heroContext.Fight();

        }
    }
}
