using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace How_Many_Of_Us.CoolComponents
{
    public abstract class MainMenu
    {
        public static ConsoleSpinner loadSpinner = new ConsoleSpinner();
        public bool startButtonPress = false;
        public int countTimer;

        public void DisplayLoadingIcon()
        {
            while (!startButtonPress)
            {
                loadSpinner.Delay = 500;
                loadSpinner.Turn(displayMsg: "Press [ENTER] to start game ", sequenceCode: 4);
            }
        }

        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(",--.  ,--.                      ,--.   ,--.                              ,-----.  ,---.    ,--. ,--.");
            Console.WriteLine("|  '--'  | ,---. ,--.   ,--.    |   `.'   | ,--,--.,--,--, ,--. ,--.    '   .-.  '/  .-'    |  | |  | ,---.");
            Console.WriteLine("|  .--.  || .-. ||  |.'.|  |    |  |'.'|  |' ,-.  ||      \\ \\  ' /     |  | |  ||  `-,    |  | |  |(  .-'");
            Console.WriteLine("|  |  |  |' '-' '|   .'.   |    |  |   |  |\\ '-'  ||  ||  |  \\  '      '  '-'  '|  .-'    '  '-'  '.-'  `)");
            Console.WriteLine("`--'  `--' `---' '--'   '--'    `--'   `--' `--`--'`--''--'.-'  /        `-----' `--'       `-----' `----'");
            Console.WriteLine("                                                           `---'                                            ");

            Console.WriteLine("Text based strategy game where you have to complete a series of maths and physics problems to take down a group of hackers.");
            //DisplayLoadingIcon();
            char ch = Console.ReadKey(true).KeyChar;
            //startButtonPress = true;
        }
    }
}
