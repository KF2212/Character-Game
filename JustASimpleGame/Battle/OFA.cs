﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class OFA
    {
        public static int StrengthAction(ICharacters opponent)
        {
            Random rand = new Random();
            return opponent.Strength * rand.Next(opponent.MinDmgWeapon, opponent.MaxDmgWeapon);
        }
    }
}
