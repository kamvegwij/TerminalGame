using How_Many_Of_Us.Challenges.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using How_Many_Of_Us.Managers;

namespace How_Many_Of_Us.CoolComponents
{
    public class CompleteShutdown
    {
        GeneratedToken Alpha = new GeneratedToken(3f,7f,4f,"Alpha");
        GeneratedToken Ghost = new GeneratedToken(5f, -10f, 3f, "Ghost");

        public void TokenCalculations()
        {
            GeneratedToken.WorldPosition crossProd = Managers.MathManager.GetCrossProduct(Alpha.TokenPosition(), Ghost.TokenPosition());
            float dotProd = Managers.MathManager.GetDotProduct(Alpha.TokenPosition(), Ghost.TokenPosition());
            Console.Clear();
            Console.WriteLine("Cross Product: " + crossProd.X.ToString() + ',' + crossProd.Y.ToString() + ',' + crossProd.Z.ToString());
            Console.WriteLine("Dot Product: " + dotProd.ToString());
        }

        public void IntroScreen()
        {
            TokenCalculations();
            Console.WriteLine("Agent, you've made your choice. Now it's time to get to work.\nOur system has been secured by tokens that exist virtually" +
                " in the break room (3-Dimensional Space)\nYou have to find the current tokens before the hackers find them\nTokens: \n(1) Alpha \n(2) Ghost\n(3) Dark Arts");

            Console.WriteLine("Tips:\n- All 3 tokens when plotted on a graph, draw a Hexagon\n- Alpha is usually perpendicular to Dark Arts (Y Axis)\n" +
                "- Alpha is at position (3,7,4)\n- To decrypt: Get 3 tokens world positions, ");
            char ch = Console.ReadKey(true).KeyChar;
            Console.WriteLine("\nHere is your checklist:\n(1) Find all 3 tokens\n(2) Decrypt the message using the 3 tokens\n(3) Backup the system\n(4) SHUTDOWN.");
        }
    }
}
