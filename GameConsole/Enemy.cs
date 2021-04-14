using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class Enemy : Character
    {
        public Enemy() : base ("Enemy", 9, 4, new HarmRange(0,3))
        {

        }
    }
}
