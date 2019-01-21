using JustASimpleGame.Battle;
using JustASimpleGame.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Arena
    {
        public static void FightInArena(ICharacters myHero,int choice)
        {
            if (choice == 1)
            {

                ICharacters opponent;
                int enemy = Arena.TypeOfEnemy(3);
                if (enemy == 1)
                {
                    opponent = new OpponentDracula(myHero.Level);
                }
                else if (enemy == 2)
                {
                    opponent = new OpponentDragon(myHero.Level);
                }
                else if (enemy == 3)
                {
                    opponent = new OpponentRay(myHero.Level);
                }
                else
                {
                    opponent = new OpponentDracula(myHero.Level);
                }
                Arena.FightLayout(myHero, opponent,true);
            }
            if (choice == 2)
            {
                ICharacters opponent;
                opponent = new ThreeHeadedDragon(16);
                if (myHero.Level>=opponent.Level && myHero.Money>=opponent.RequiredMoney)
                {
                    Arena.FightLayout(myHero, opponent, true);
                }
                else
                {
                    Console.WriteLine("You are not allowed to enter there. You have to have the"+opponent.Level+" and "+opponent.RequiredMoney+" money");
                    Thread.Sleep(2000);
                    CityMap.ShowMap(myHero);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You chose life!");
                Console.WriteLine();
                Console.Clear();
            }
        }
        private static int TypeOfEnemy(int enemyCharacters)
        {
            Random rand = new Random();
            return rand.Next(0, (enemyCharacters + 1));
        }
        public static void FightLayout(ICharacters character, ICharacters opponent,bool co)
        {
            Console.Clear();
            if (co == true)
            {
                Thread thread2 = new Thread(() => ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, 1));
                thread2.Start();
                ChoicesOnFight.FightChoices(ref character, ref opponent, 1);
            }
            else
            {
                Thread.CurrentThread.Abort();
                if (opponent == new ThreeHeadedDragon())
                {
                    Arena.Boss(character, opponent);
                }
                else
                {
                    Arena.AfterFight(ref character, ref opponent);

                }
            }
        }
        public static void Boss(ICharacters myHero, ICharacters opponent)
        {
            Console.Clear();
            Console.WriteLine("YOU WIN!!!BOOOOOOOS :)");
            Thread.Sleep(2000);
            //character.AmountOfAtributes += 5;
            //opponent.HitPoints = 0;
            //character.HitPoints = 0;
            //character.HitPoints += 100;
            //opponent.HitPoints += 100;
            //MoneyAssignment.MoneyAfterFight(character);
            //Increase.Add(character);
        }
        public static void AfterFight(ref ICharacters character,ref ICharacters opponent)
        {
            
            if (opponent.HitPoints <= 80)
            {
                Console.Clear();
                Console.WriteLine("YOU WIN!!! :)");
                Thread.Sleep(2000);
                character.AmountOfAtributes += 5;
                opponent.HitPoints = 0;
                character.HitPoints = 0;
                character.HitPoints += 100;
                opponent.HitPoints += 100;
                MoneyAssignment.MoneyAfterFight(ref character);
                Increase.Add(character);
                
            }
            if (character.HitPoints <= 80)
            {
                Console.WriteLine("YOU LOST!");
                Thread.Sleep(2000);
                opponent.HitPoints = 0;
                character.HitPoints = 0;
                character.HitPoints += 100;
                opponent.HitPoints += 100;
                MoneyAfterDefeat.MoneyAfterFight(character);
            }

        }
        
    }
}
