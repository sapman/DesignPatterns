using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Device
    {
        public int Status { get; protected set; }
        public int Max { get; protected set; }
        public bool IsOn { get; protected set; }

        protected Device(int status, int max, bool isOn)
        {
            Status = status;
            Max = max;
            IsOn = isOn;
        }

        public abstract void PrintStatus();
        public virtual void PressNext()
        {
            Status = (Status + 1) % Max;
        }
        public virtual void PressPrevious()
        {
            Status = (Status - 1) % Max;
        }

        public bool Turn(bool on)
        {
            this.IsOn = on;
            return IsOn;
        }

        public bool TurnOn()
        {
            return Turn(true);
        }
        public bool TurnOff()
        {
            return Turn(false);
        }
    }
}
