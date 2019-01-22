using System;
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
            this.Skill = 3;
            this.Strength = 1;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.Money = 100;
            this.TimeForActions = new int[6];
            this.HeldArmor = 10;
            this.MinDmgWeapon = 2;
            this.MaxDmgWeapon = 2;
            this.Lista = new List<int>();
            this.AmountOfAtributes = 5;
        }
        public override void Picture()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
