using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class TIM
    {
        public static void SetTime(ICharacters opponent, string choice)
        {
            choice = choice.ToUpper();
            DateTime date = DateTime.Now;
            switch (choice)
            {
                case "ATTACK":
                    {
                        opponent.TimeForActions[0] = date.Minute;
                        opponent.TimeForActions[1] = date.Second + 5;
                        //Console.WriteLine(character.TimeForActions[1]);
                        //Console.ReadKey();
                        break;
                    }
                case "SPELL":
                    {
                        opponent.TimeForActions[2] = date.Minute;
                        opponent.TimeForActions[3] = date.Second + 10;
                        break;
                    }
                    //case "ITEMS":
                    //    {
                    //        character.TimeForActions[4] = date.Minute;
                    //        character.TimeForActions[5] = date.Second + 5;
                    //        break;
                    //    }
            }
        }
        
        public static void IfActionPossible(ICharacters opponent, int whatAction, out int ifPossible)
        {
            DateTime dateNow = DateTime.Now;
            if (opponent.TimeForActions[0 + whatAction] == dateNow.Minute)
            {
                if (opponent.TimeForActions[1 + whatAction] < dateNow.Second)
                {
                    ifPossible = 1;
                    ////Console.WriteLine("ok"+ opponent.TimeForActions[0 + whatAction]+opponent.TimeForActions[1+whatAction]+"       "+dateNow.Minute+dateNow.Second);

                    Thread.Sleep(1000);

                }
                else
                {
                    ifPossible = 0;
                    //Console.WriteLine("nie" + opponent.TimeForActions[0 + whatAction] + opponent.TimeForActions[1 + whatAction] + "       " + dateNow.Minute + dateNow.Second);

                    Thread.Sleep(1000);

                }
            }
            else
            {
                if (opponent.TimeForActions[0 + whatAction] < 60)
                {
                    ifPossible = 1;
                    //Console.WriteLine("ok" + opponent.TimeForActions[0 + whatAction] + opponent.TimeForActions[1 + whatAction] + "       " + dateNow.Minute + dateNow.Second);

                    Thread.Sleep(1000);



                }
                else if (opponent.TimeForActions[0 + whatAction] % 60 < dateNow.Second % 60)
                {
                    ifPossible = 1;
                   // Console.WriteLine("ok" + opponent.TimeForActions[0 + whatAction] + opponent.TimeForActions[1 + whatAction] + "       " + dateNow.Minute + dateNow.Second);

                    Thread.Sleep(1000);


                }
                else
                {
                    ifPossible = 0;
                    //Console.WriteLine("nie" + opponent.TimeForActions[0 + whatAction] + opponent.TimeForActions[1 + whatAction] + "       " + dateNow.Minute + dateNow.Second);

                    Thread.Sleep(1000);

                }
            }
        }
    }
}
