using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_Many_Of_Us.Managers
{
    public class TaskManager
    {
        public TaskManager() { }

        public int choicePath;
        public float hackerAccessTotal;

        public int ChosenPath { get { return choicePath; } set { choicePath = value; } }
        public float TotalAccessPercent { get { return hackerAccessTotal; } set { hackerAccessTotal = value; } }

        public void DisplayCurrentHackerAccess()
        {
            Console.WriteLine("\nHackers have " + hackerAccessTotal.ToString() + "% access.\n");
        }
    }
}
