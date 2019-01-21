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
            Console.WriteLine("There are your atributes: ");
            ChangeNumbersToPlus.Durability(character);
            ChangeNumbersToPlus.Intelligence(character);
            ChangeNumbersToPlus.Skill(character);
            ChangeNumbersToPlus.Strength(character);
            Console.WriteLine("At the start of the game you have: " + character.AmountOfAtributes+" atributes to alocate.\nYou will get atributes also when you will win fight with opponent.");
            //Console.WriteLine("2.Decrease your Atributes(Change your Atributes)");
            //int choice = OnInputWork.ChoiceHandler();
            //switch (choice)
            //{
            //    case 1:
            //{
            Thread.Sleep(5000);
                        Increase.Add(character);
                        //break;
                    //}
                //case 2:
                //    {
                //        Decrease.DecreaseAtribute(character);
                //        break;
                //    }

                //default:
                //    {
                //        Console.Clear();
                //        Console.WriteLine("Wrong number try again");
                //        Thread.Sleep(750);
                //        Console.Clear();
                //        CreationACharacter.Choice(character);
                //        break;

                //    }
            

        }

    }
}