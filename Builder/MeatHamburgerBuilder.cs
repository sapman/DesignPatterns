using System;
namespace Builder
{
    public class MeatHamburgerBuilder : HamburgerBuilder
    {
        public MeatHamburgerBuilder()
        {
        }

        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Healthy flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("MEAT");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("Fat cream");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 70 ILS");
        }
    }
}
