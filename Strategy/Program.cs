using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
           Hero bruceWayne = new Batman(new Fight());
           bruceWayne.DoHeroAction();
           bruceWayne.SetHeroAction(new Taunt());
           bruceWayne.DoHeroAction();

        }
    }
}
