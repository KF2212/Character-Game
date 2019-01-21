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
            this.Skill = 2;
            this.Strength = 3;
            this.Luck = 1;
            this.Level = 1;
            this.HitPoints = 100;
            this.Money = 0;
            this.TimeForActions = new int[6];

        }
        public OpponentRay(int level)
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