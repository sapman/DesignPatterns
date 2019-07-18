using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Eight
{
    public abstract class TemplatePractice
    {
        protected abstract void ChangeClothes();
        protected abstract void DrinkWater();
        protected abstract void Drill();
        protected abstract void Shower();
            
        public void Run()
        {
            Console.WriteLine("-----Statrting Practice-----");
            ChangeClothes();
            DrinkWater();
            Drill();
            Shower();
            Console.WriteLine("-----Finishing Practice-----");
        }
    }
}
