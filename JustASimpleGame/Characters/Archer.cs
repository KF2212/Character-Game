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
            this.Durability = 2;
            this.Intelligence = 3;
            this.Skill = 2;
            this.Strength = 60;
            this.Luck = 1;
            this.Level = 18;
            this.HitPoints = 100;
            this.Money = 5000;
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
            Console.WriteLine("              | 0 *|         )      ");
            Console.WriteLine("              \\_--_/          )       ");
            Console.WriteLine("          ______||___          )       ");
            Console.WriteLine("         |______|----|--------->       ");
            Console.WriteLine("             |        \\_____   )");
            Console.WriteLine("             |______|\\______| )");
            Console.WriteLine("             |   |  |        )");
            Console.WriteLine("             |   |  |  ");
            Console.WriteLine("             |___|__|  ");
        }
        
    }
}
