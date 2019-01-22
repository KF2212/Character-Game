﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Characters
{
        class ThreeHeadedDragon : CharacterData, ICharacters
        {
            public ThreeHeadedDragon()
            {
                this.Durability = 4;
                this.Intelligence =1;
                this.Skill = 1;
                this.Strength =4;
                this.Luck = 1;
                this.HitPoints = 100;
                this.TimeForActions = new int[6];
                this.HeldArmor = 20;
                this.MinDmgWeapon = 10;
                this.MaxDmgWeapon = 40;
                this.Lista = new List<int>();

        }
        public ThreeHeadedDragon(int level)
        {
            this.Durability = 4 + 2 * level;
            this.Intelligence = 1 + 1 * level;
            this.Skill = 1+1*level;
            this.Strength = 4 + 3 * level;
            this.HitPoints = 100;
            this.Level = 16;
            this.RequiredMoney = 2000;
            this.TimeForActions = new int[6];

        }
            public override void Picture()
            {   

                Console.WriteLine("                                      ");
                Console.WriteLine("            __    __                    ");
                Console.WriteLine("      __    \\ \\__/ /    __              ");
                Console.WriteLine("   __/ *\\   | *  * |   /* \\__               ");
                Console.WriteLine("  /____  \\  \\_----_/  /  ____\\           ");
                Console.WriteLine("  \\_____  \\   |  |   /   ____/            ");
                Console.WriteLine("        \\  \\  |  |  /   /                   ");
                Console.WriteLine("  _____  \\  \\/    \\/   / ______                 ");
                Console.WriteLine("  \\    \\  \\           / /     /                ");
                Console.WriteLine("   \\    \\ /           \\/     /              ");
                Console.WriteLine("    \\__   |           |   __/               ");
                Console.WriteLine("       \\__|           |__/                    ");
                Console.WriteLine("          \\           /                     ");
                Console.WriteLine("          _\\         /__                        ");
                Console.WriteLine("         |___|___|___|__|      ");
            }

        }
    
}
