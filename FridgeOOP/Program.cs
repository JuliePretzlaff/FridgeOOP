using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Want to create an interactive window
            //Prompt user to choose what to do with the fridge
            //Call methods on fridge object to do what user wants

            string userChoice = Console.ReadLine();
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1.");
                Console.WriteLine("To change the lightbulb, type 2.");
                Console.WriteLine("To clean, type 3.");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check supplies, type 5.");
                Console.WriteLine("To see all fridge details, type 6.");
                Console.WriteLine("To restart, type 7.");
                Console.WriteLine("To quit, type 8.");

                


            } while (userChoice != "8");
        }
    }
}
