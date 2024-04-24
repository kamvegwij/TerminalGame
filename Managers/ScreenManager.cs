using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_Many_Of_Us.Managers
{
    public abstract class ScreenManager
    {
        public static void CleanTerminalScreen()
        {
            Console.WriteLine("Press [ENTER] to continue.");
            char ch = Console.ReadKey(true).KeyChar;
            Console.Clear();
        }

        public static void WrapImportantInfo(string stemp)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(stemp);
            Console.ResetColor();
        }

    }
}
