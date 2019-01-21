using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Characters
{
    class MoneyAfterDefeat
    {
        public static void MoneyAfterFight(ICharacters character)
        {
            Console.Clear();
            Random Rand0 = new Random();
            int AdditionalMoney = Rand0.Next(10, 20);
            int WinMoney = character.Level * 20 + AdditionalMoney;
            int SumOfMoney = character.Money + character.Level * 20 + AdditionalMoney;
            Console.WriteLine("You defeat but you get: " + WinMoney + " money. Together you have: " + SumOfMoney + "money!");
            Thread.Sleep(5000);

        }
    }
}
