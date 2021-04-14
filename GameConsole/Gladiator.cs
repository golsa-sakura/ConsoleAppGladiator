using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class Gladiator : Character
    {
        public Gladiator() : base ("Gladiator", 10, 3,  new HarmRange(0,5))
        {

        }
    }
}
