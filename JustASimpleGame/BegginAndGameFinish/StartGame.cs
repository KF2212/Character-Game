using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class StartGame
    {
        public static void CreatingCharacter(ref CharacterData character)
        {
            Console.Clear();
            Console.WriteLine("What type of character would you like to choose?");
            Console.WriteLine("1.Giant");
            Console.WriteLine("2.Wizard");
            Console.WriteLine("3.Archer");
            Console.WriteLine("4.To get more information about them");
            Console.WriteLine("5.Back");
            int Choice=OnInputWork.ChoiceHandler();
            switch(Choice)
            {
                case 1:
                    {
                        StartGame.GiantCharacter(out character);
                        CreationACharacter.Choice(character);
                        break;
                    }
                case 2:
                    {
                        StartGame.WizardCharacter(out character);
                        CreationACharacter.Choice(character);

                        break;
                    }
                case 3:
                    {
                        StartGame.ArcherCharacter(out character);
                        CreationACharacter.Choice(character);

                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        StartGame.HeroTypeInformation();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        GameInvocation.OptionsSelector();
                        break;
                    }
            }
        }
        public static void HeroTypeInformation()
        {
            Console.WriteLine("Warrior");
            Console.WriteLine("Mage");
            Console.WriteLine("Archer");
        }
        public static void GiantCharacter(out CharacterData character)
        {
            Giant gigant = new Giant();
            character = gigant;
        }
        public static void WizardCharacter(out CharacterData character)
        {
            Wizard wizard = new Wizard();
            character = wizard;
        }
        public static void ArcherCharacter(out CharacterData character)
        {
            Archer archer = new Archer();
            character = archer;
        }
    }
}
