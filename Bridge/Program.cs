using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Memir memir = new Memir(1, 10, false);
            TV tv = new TV(5, 99, true);

            RemoteControl remote = new RemoteControl(memir);
            remote.PrintStatus();
            remote.On();
            remote.PrintStatus();
            remote.Next();
            remote.Prev();
            remote.PrintStatus();

            remote.Device = tv;
            remote.PrintStatus();
            remote.Off();
            remote.Next();
            remote.PrintStatus();
        }
    }
}
