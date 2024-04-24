using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using How_Many_Of_Us.CoolComponents;
using How_Many_Of_Us.Hacker;
using How_Many_Of_Us.Managers;

namespace How_Many_Of_Us
{

    class Program
    {
        public static TaskManager taskManager = new TaskManager();

        public static Hackers Pigeon = new Hackers(43, 20, "Pigeon", "#@");
        public static Hackers RabbitFox = new Hackers(27, 60, "RabbitFox", "^..^");
        public static Hackers Ghost = new Hackers(23, 10, "Ghost", ":}");
        public static char ch;

        private static string AgentUsername = "JG";
        private static string AgentPassword = "g4";
        private static bool isLoggedIn = false;
        private static bool canLogin = true;

        public static void DestroyLoginDetails()
        {
            AgentPassword = "";
            AgentUsername = "";
            isLoggedIn = true;
            canLogin = false;
        }
        public static bool CheckLogin(string username, string password)
        {
            if(username == AgentUsername && password == AgentPassword)
            {
                return true;
            }
            return false;
        }

        public static void IntroScreen()
        {
            Console.Clear();

            Console.WriteLine("New message from Agent Bxk: ");
            Console.WriteLine("Agent, we have a big problem!\nIt's being reported that a group of hackers has infiltrated the network! " +
                "\nThe identities of the criminals is unknown, " +
                "but we have some information about their profiles.\n press any key to expand message.\n");

            ScreenManager.CleanTerminalScreen();

            //show avatars as algorithm patterns.
            Console.WriteLine("\nAlias: " + Pigeon.Name + "\nAge: " + Pigeon.Age.ToString() + "\nAccess(%): " + Pigeon.Access.ToString() + "\nAvatar: " + Pigeon.Avatar);
            Console.WriteLine("\nAlias: " + RabbitFox.Name + "\nAge: " + RabbitFox.Age.ToString() + "\nAccess(%): " + RabbitFox.Access.ToString() + "\nAvatar: " + RabbitFox.Avatar);
            Console.WriteLine("\nAlias: " + Ghost.Name + "\nAge: " + Ghost.Age.ToString() + "\nAccess(%): " + Ghost.Access.ToString() + "\nAvatar: " + Ghost.Avatar);
            Console.WriteLine("\nThe info shows their alias, age, access to our organization and last used avatar\n");

            ScreenManager.CleanTerminalScreen();

            Console.WriteLine("The first thing we want you to do is login in to the main desk, so you can find them. I have sent an encrypted message with your updated" +
                " details. press any key to expand message\n");


            ScreenManager.WrapImportantInfo("Username: JG\nPassword: g4\n These will be destroyed the second you login.");
           // ScreenManager.CleanTerminalScreen();
        }

        public static void LoginAgent()
        {
            string username = ""; string password = "";
            while (!isLoggedIn)
            {
                if (CheckLogin(username, password) == true)
                {
                    ScreenManager.CleanTerminalScreen();
                    Console.WriteLine("***Welcome To The Main Desk***");
                    DestroyLoginDetails();
                    Console.WriteLine("Agent, now is the time to get going. \nThe hackers currently have " + taskManager.hackerAccessTotal.ToString() + "% access to the system!\n" +
                        "If they get 60% or more, we are in big trouble!");
                    Console.WriteLine("\nYou must attempt to shutdown the entire system and make a backup");
                }
                else
                {
                    ScreenManager.CleanTerminalScreen();
                    Console.WriteLine("Agent Username: "); username = Console.ReadLine(); 
                    Console.WriteLine("Agent Password: "); password = Console.ReadLine();
                }
            }
        }
        
        static void Main(string[] args)
        {
            CompleteShutdown shutdown = new CompleteShutdown();
            taskManager.hackerAccessTotal = ((Pigeon.Access + RabbitFox.Access + Ghost.Access) / 300) * 100;
            
            MainMenu.DisplayMainMenu();
            //IntroScreen();
            //LoginAgent();
            ScreenManager.CleanTerminalScreen();
            ScreenManager.WrapImportantInfo("You've got alot of work to do Agent, goodluck!");
            shutdown.IntroScreen();
        }
    }
}
