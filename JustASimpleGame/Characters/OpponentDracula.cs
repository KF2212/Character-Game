using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OpponentDracula : CharacterData,ICharacters
    {
        public OpponentDracula()
        {
            this.Durability = 2;
            this.Intelligence = 1;
            this.Skill = 2;
            this.Strength = 3;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.Money = 0;
          
            this.TimeForActions = new int[6];

        }
        public OpponentDracula(int level)
        {
            this.Durability = 1+1*level;
            this.Intelligence = 1+3*level;
            this.Skill = 2;
            this.Strength = 1+1*level;
            this.HitPoints = 100;

            this.TimeForActions = new int[6];

        }
        public override void Picture()
        {
            Console.WriteLine("           ____________       ");
            Console.WriteLine("          / _________  \\");
            Console.WriteLine("          | | _   _  | | ");
            Console.WriteLine("          | | 0   0  | | ");
            Console.WriteLine("   ___    | | ______ | |    ___");
            Console.WriteLine("  |_|_|   | ||\\/\\/\\/|| |   |_|_|");
            Console.WriteLine("   | |    |/||_/\\/\\_||\\|    | | ");
            Console.WriteLine("   \\ \\____| |________| |____/ /");
            Console.WriteLine("    \\_______           ______/");
            Console.WriteLine("            |         | ");
            Console.WriteLine("            |_________| ");
            Console.WriteLine("            |_________| ");
            Console.WriteLine("            |    |    | ");
            Console.WriteLine("           _|____|____|_ ");
            Console.WriteLine("          |_____________| ");






        }
    }
}
