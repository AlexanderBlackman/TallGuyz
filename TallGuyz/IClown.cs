using System;
using System.Collections.Generic;
using System.Text;

namespace TallGuyz
{
    interface IClown
    {
         void Honk();

        public string FunnyThingsIHave { get;}

        static private int carCapacity = 12;
        protected static Random random = new Random();
        static public int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10) carCapacity = value;
                else Console.WriteLine($"Warning: Car capacity {value} is too small");
            }
        }

        public static string ClownCarDescription()
        {
            return $"packed like a tardis with {random.Next(CarCapacity / 2, CarCapacity)} clowns";
        }

    }

    interface IScaryClown: IClown
    {
        void ScareLittleChildren();

        public string ScaryThingsIHave { get;  }


    }






}

