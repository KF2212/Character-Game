using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Giant : CharacterData, ICharacters
    {
        public Giant()
        {
            this.Durability = 4;
            this.Intelligence = 1;
            this.Skill = 2;
            this.Strength = 4;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 150;
            this.Money = 0;
            this.TimeForActions = new int[6];
            this.HeldArmor = 10;
            this.MinDmgWeapon = 2;
            this.MaxDmgWeapon = 2;
            this.Lista = new List<int>();
            this.AmountOfAtributes = 5;



        }
        public override void Picture()
        {
            Console.WriteLine("           _______");
            Console.WriteLine("          /       \\ ");
            Console.WriteLine("          | *  *  ||");
            Console.WriteLine("          |  __   ||");
            Console.WriteLine("     _____\\_______/____");
            Console.WriteLine("    /                  \\");
            Console.WriteLine("   /                    \\");
            Console.WriteLine("   |      |      |      |");
            Console.WriteLine("   |_|__|_|      |_|__|_|");
            Console.WriteLine("         |________|");
            Console.WriteLine("         |___|_|__|  ");
            Console.WriteLine("         |____|___|    ");
        }
    }
}
