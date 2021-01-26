using System;

namespace TallGuyz
{

    class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
           if (fingersTheClown is IScaryClown scaryClown)
                scaryClown.ScareLittleChildren();
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());
        }
    }
}
