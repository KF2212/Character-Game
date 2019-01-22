using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class ChoicesOnFightOpponent
    {
        public static void FightChoices(ref ICharacters opponent, ref ICharacters character, int ifPossible)
        {
            //Console.Clear();
            //var options = new Dictionary<string, Int32>
            //{
            //    ["Attack"] = 1,
            //    ["Item"] = 3,
            //    ["Spells"] = 2,
            //    ["Tactical retreat"] = 4
            //};
            //for (int i = 0; i < (27 * 2 + 2); i++)
            //{
            //    Console.Write("=");
            //}
            //Console.Write("\n");
            //for (int i = 0; i < options.Count; i += 2)
            //{
            //    var items = options.Skip(i).Take(2);
            //    Console.Write("|");
            //    foreach (var item in items)
            //    {
            //        Console.Write($"|{item.Value,3}||{item.Key,-20}|");
            //    }
            //    Console.Write("|\n");
            //}

            //for (int i = 0; i < (27 * 2 + 2); i++)
            //{
            //    Console.Write("=");
            //}
            //Console.WriteLine("\n");
            if (character.HitPoints <= 80 || opponent.HitPoints <= 80)
            {
                Arena.FightLayout(character, opponent, false);
            }
            Random Rand0 = new Random();
            int choice = Rand0.Next(1, 4);
            ChoicesOnFightOpponent.FightOptionsHandler(choice, ref opponent, ref character, out ifPossible);

        }
        public static void FightOptionsHandler(int choice, ref ICharacters opponent, ref ICharacters character, out int ifPossible)
        {

            switch (choice)
            {
                case 1:
                    {
                        TIM.IfActionPossible(opponent, 0, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionAttackOpponent.AttackMechanics(ref opponent, ref character, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        }
                        break;
                    }
                case 2:
                    {
                        TIM.IfActionPossible(opponent, 2, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionAttackOpponent.SpellMechanics(ref opponent, ref character, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        }
                        break;
                    }
                case 3:
                    {
                        TIM.IfActionPossible(opponent, 4, out ifPossible);
                        if (ifPossible == 1)
                        {
                            ifPossible = 1;
                            FightOptionItemOpponent.ItemMechanics(ref opponent, ref character, ifPossible);
                        }
                        else
                        {
                            ifPossible = 0;
                            ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        }
                        break;
                    }
                default:
                    {
                        ifPossible = 1;
                        ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                        break;
                    }
            }
        }
    }
}
