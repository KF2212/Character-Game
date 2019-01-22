using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OpponentRay : CharacterData, ICharacters
    {
        public OpponentRay()
        {
            this.Durability = 2;
            this.Intelligence = 1;
            this.Skill = 3;
            this.Strength = 4;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.Money = 0;
            this.TimeForActions = new int[6];

        }
        public OpponentRay(int level)
        {
            this.Durability = 2 + 2 * level;
            this.Intelligence = 1 + 1 * level;
            this.Skill = 3 + 1 * level;
            this.Strength = 4 + 3 * level;
            this.HitPoints = 100;
            this.TimeForActions = new int[6];
        }
        public override void Picture()
        {
            Console.WriteLine("              ' ' ' /\\  '  ' ''  ");
            Console.WriteLine("               ' ' /  \\  ' ''");
            Console.WriteLine("             '  ' /    \\'  '");
            Console.WriteLine("             '  '/ 0  0 \\'  '");
            Console.WriteLine("              ' /   --   \\'  '");
            Console.WriteLine("             ' |          |'");
            Console.WriteLine("                \\        /");
            Console.WriteLine("                 \\_/\\/\\_/   ");


        }
    }
}