using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class FightOptionItem
    {
        public static ICharacters Item(ref ICharacters character)
        { int i = 1;
            Console.WriteLine("You have items:");
            foreach (int item in character.Lista )
            {
                Console.WriteLine(i+": "+item);
                i++;
            }
            Console.WriteLine("");
            int Choice = OnInputWork.ChoiceHandler();
            if (Choice <= character.Lista.Count)
            {
                character.HitPoints += character.Lista[Choice-1];
                character.Lista.RemoveAt(Choice-1);
                Console.WriteLine("no i nie masz");
            }
            else
            {
                Console.WriteLine("Wrong number! Try again");
                //FightOptionItem.Item(ref character);
            }
            return character;
        }
        public static void ItemMechanics(ref ICharacters character, ref ICharacters opponent, int ifPossible)
        {
            Console.WriteLine("no i nie masz");

            FightOptionItem.Item(ref character);
            Timer.SetTime(character, "ITEM");
            ChoicesOnFight.FightChoices(ref character, ref opponent, ifPossible);
        }
    }
}
