using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Tools
{
    class GoingMap
    {
        public static void StartTxt()
        {
            int origWidth = 110;
            int origHeight = 20;
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            BackgroundColor.Color();
            for (int i = 0; i < 3; i++)
            {
                string s = "Going Map...";
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.SetCursorPosition((origWidth - s.Length) / 2, Console.CursorTop);
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}
