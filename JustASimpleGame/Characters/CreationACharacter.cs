using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class CreationACharacter
    {
        public static void Choice(ICharacters character)
        {
            Console.Clear();
            Console.WriteLine("You have: ");
            ChangeNumbersToPlus.Durability(character);
            ChangeNumbersToPlus.Intelligence(character);
            ChangeNumbersToPlus.Skill(character);
            ChangeNumbersToPlus.Strength(character);
            Console.WriteLine("You Have: " + character.AmountOfAtributes+" to alocate. To increase atributes click 1 ");
            //Console.WriteLine("2.Decrease your Atributes(Change your Atributes)");
            int choice = OnInputWork.ChoiceHandler();
            switch (choice)
            {
                case 1:
                    {
                        Increase.Add(character);
                        break;
                    }
                //case 2:
                //    {
                //        Decrease.DecreaseAtribute(character);
                //        break;
                //    }

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong number try again");
                        Thread.Sleep(750);
                        Console.Clear();
                        CreationACharacter.Choice(character);
                        break;

                    }
            }

        }

    }
}