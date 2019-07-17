using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Memir : Device
    {
        public Memir(int status, int max, bool isOn) : base(status, max, isOn)
        {
        }

        public override void PressNext()
        {
            base.PressNext();
            Console.WriteLine("Next program");
        }

        public override void PressPrevious()
        {
            base.PressPrevious();
            Console.WriteLine("Previous program");
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"Program {Status}, {(IsOn? "On": "Off")}");
        }
    }

    public class TV : Device
    {
        public TV(int status, int max, bool isOn) : base(status, max, isOn)
        {
        }

        public override void PressNext()
        {
            base.PressNext();
            Console.WriteLine("Next channel");
        }

        public override void PressPrevious()
        {
            base.PressPrevious();
            Console.WriteLine("Previous channel");
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"Channel {Status}, {(IsOn ? "On" : "Off")}");
        }
    }
}
