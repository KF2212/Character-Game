using System;
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
                this.Durability = 10;
                this.Intelligence = 20;
                this.Skill = 10;
                this.Strength = 13;
                this.Luck = 1;
                this.HitPoints = 100;
                this.TimeForActions = new int[6];
                this.HeldArmor = 10;
                this.MinDmgWeapon = 10;
                this.MaxDmgWeapon = 10;
                this.Lista = new List<int>();

        }
        public ThreeHeadedDragon(int level)
        {
            this.Durability = 1 + 1 * level;
            this.Intelligence = 1 + 3 * level;
            this.Skill = 2;
            this.Strength = 1 + 1 * level;
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
