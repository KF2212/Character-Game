using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class MoneyAssignment : CharacterData, ICharacters
    {
        public static void MoneyAfterFight(ref ICharacters character)
        {
            Console.Clear();
            Random Rand0 = new Random();
            int AdditionalMoney = Rand0.Next(100, 200);
            int WinMoney =  character.Level * 20 + AdditionalMoney;
            int SumOfMoney =character.Money+ character.Level * 20 + AdditionalMoney;
            character.Money += WinMoney;
            Console.WriteLine("You win: " + WinMoney+" money. Together you have: "+character.Money+" money!");
            Thread.Sleep(5000);

        }

    }
}