using System;
using System.Collections.Generic;
using System.Text;

namespace TallGuyz
{
    class FunnyFunny : IClown
    {
        private string funnyThingsIHave;

        public string FunnyThingsIHave { get { return funnyThingsIHave; } }

        public FunnyFunny(string funnyThing)
        {
            this.funnyThingsIHave = funnyThing;
        }



        public void Honk()
        {
            Console.WriteLine($"Honk honk goes the horn\nI have a {funnyThingsIHave}");
        }


    }

    class ScaryScary : FunnyFunny, IScaryClown
    {
        readonly int ScaryCount;
        public string FunnyThingsIHave { get; }
        public string ScaryThingsIHave { get { return ScaryCount + " Spiders"; } }

       public  ScaryScary(string funnyThing, int scaryCount): base(funnyThing)
        {          
          //  this.FunnyThingsIHave = funnyThing;
            this.ScaryCount = scaryCount;
        }
        
        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo!!! Look at my scary {ScaryThingsIHave}");
        }
    }
}
