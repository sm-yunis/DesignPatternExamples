using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
           Hero bruceWayne = new Batman(new Taunt("I'm Batman"));
           bruceWayne.DoHeroAction();

           bruceWayne.SetHeroAction(new Fight("Batman beating thugs with fancy gadgets"));
           bruceWayne.DoHeroAction();

           Hero thor = new Thor(new Taunt("Thor the might son of Odin"));
           thor.DoHeroAction();

           thor.SetHeroAction(new Fight("Thor swinging his Mjölnir on giants"));
           thor.DoHeroAction(); 

        }
    }
}
