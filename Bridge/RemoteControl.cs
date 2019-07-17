using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class RemoteControl
    {
        public Device Device { get; set; }

        public RemoteControl(Device device)
        {
            Device = device;
        }

        public void On()
        {
            Device.TurnOn();
        }

        public void Off()
        {
            Device.TurnOff();
        }

        public void Next()
        {
            Device.PressNext();
        }
        public void Prev()
        {
            Device.PressPrevious();
        }

        public void PrintStatus()
        {
            Device.PrintStatus();
        }
    }
}
