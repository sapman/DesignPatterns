using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Eight
{
    public abstract class PracticeBase : TemplatePractice
    {
        protected override void ChangeClothes()
        {
            Console.WriteLine("Changing clothes...");
        }

        protected override void DrinkWater()
        {
            Console.WriteLine("Drinking Neviot...");
        }

        protected override void Shower()
        {
            Console.WriteLine("Taking a shower...");
        }
    }
}
