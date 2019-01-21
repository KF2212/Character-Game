using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    static class GameInvocation
    {
        public static void OptionsSelector()
        {
            Console.WriteLine("1.Start Game");
            Console.WriteLine("2.Options");
            Console.WriteLine("3.Exit");
            GameInvocation.OpeningActionHandler();
            
        }
        public static void OpeningActionHandler()
        {
            int Choice=OnInputWork.ChoiceHandler();
            switch(Choice)
            {
                case 1:
                    {
                        Console.Clear();
                        CharacterData character = new CharacterData();
                        StartGame.CreatingCharacter(ref character);
                        //Console.WriteLine("1");
                        break;
                    }
                case 2:
                    {
                        //Console.WriteLine("2");

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Thanks for Playing!");
                        //Console.WriteLine("3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Select action from listed above!");
                        break;
                    }

            }

        }
    }
}
