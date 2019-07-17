using System;
namespace Builder
{
    public class MeatHamburgerLettuce : MeatHamburgerBuilder
    {
        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Lettuces XD");
        }
    }
}
