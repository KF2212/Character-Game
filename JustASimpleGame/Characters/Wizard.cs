﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Wizard : CharacterData, ICharacters
    {
        public Wizard()
        {
            this.Durability = 2;
            this.Intelligence = 4;
            this.Skill = 2;
            this.Strength = 1;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.Money = 0;
            this.TimeForActions = new int[6];
            this.HeldArmor = 10;
            this.MinDmgWeapon = 2;
            this.MaxDmgWeapon = 2;
            this.Lista = new List<int>();



        }
        public override void Picture()
        {
            Console.WriteLine("                /\\");
            Console.WriteLine("               /  \\");
            Console.WriteLine("             ---------");
            Console.WriteLine("              | * *|     |");
            Console.WriteLine("              \\_--_/     |");
            Console.WriteLine("              __||___    |");
            Console.WriteLine("             /       \\  _|_");
            Console.WriteLine("            / /|   |\\ \\/ /");
            Console.WriteLine("           /_/ |___| \\__/");
            Console.WriteLine("               | | |    ");
            Console.WriteLine("               |_|_|");
        }
    }
}
