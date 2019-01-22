using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Archer : CharacterData, ICharacters
    {
        public Archer()
        {
            this.Durability = 1;
            this.Intelligence = 3;
            this.Skill = 4;
            this.Strength = 2;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.Money = 200;
            this.TimeForActions = new int[6];
            this.HeldArmor = 10;
            this.MinDmgWeapon = 2;
            this.MaxDmgWeapon = 2;
            this.ListOfItems = new List<int>();
            this.AmountOfAtributes = 5;

        }
        public override void Picture()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                /\\");
            Console.WriteLine("               /  \\");
            Console.WriteLine("             ---------");
            Console.WriteLine("              | 0 *|         )      ");
            Console.WriteLine("              \\_--_/          )       ");
            Console.WriteLine("          ______||___          )       ");
            Console.WriteLine("         |______|----|--------->       ");
            Console.WriteLine("             |        \\_____   )");
            Console.WriteLine("             |______|\\______| )");
            Console.WriteLine("             |   |  |        )");
            Console.WriteLine("             |   |  |  ");
            Console.WriteLine("             |___|__|  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

        }

    }
}
