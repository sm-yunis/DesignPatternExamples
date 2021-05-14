
enum Hero
{
    Batman, Thor , SpiderMan
}

static class HeroFactory {
    public static HeroContext HeroContextFactory(Hero heroName) => 
        heroName switch {
            Hero.Batman  => new HeroContext(new Batman()),
            Hero.Thor => new HeroContext(new Thor()),
            Hero.SpiderMan => new HeroContext(new SpiderMan()),
            _ => null
        };
}