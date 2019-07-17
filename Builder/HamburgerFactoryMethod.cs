using System;
namespace Builder
{
    public class HamburgerFactoryMethod
    {
        public HamburgerFactoryMethod()
        {
        }


        public Hamburger GetVehicle(string hamburgerType)
        {
            if (hamburgerType == "Veggie")
            {
                HamburgerBuilder temp = new VeggHamburgerBuilder();
                temp.BuildHamburger();

                return temp.GetHamburger();
            }
            else if (hamburgerType == "VeggieLettuce")
            {
                HamburgerBuilder temp = new VeggHambBuilderLettuce();
                temp.BuildHamburger();

                return temp.GetHamburger();
            }
            else if (hamburgerType == "Meat")
            {
                HamburgerBuilder temp = new MeatHamburgerBuilder();
                temp.BuildHamburger();

                return temp.GetHamburger();
            }
            else if (hamburgerType == "MeatLettuce")
            {
                HamburgerBuilder temp = new MeatHamburgerLettuce();
                temp.BuildHamburger();

                return temp.GetHamburger();
            }

            throw (new Exception("Invalid hamburger type"));
        }
    }
}
}
