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

            int userChoice;
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

                Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);
               userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;
                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;

                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;

                    case 4:
                        Console.WriteLine("How much food are you removing?");
                        int foodRemoved = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodRemoved);
                        Console.WriteLine("Remaining food amount is " + userFridge.FoodAmount);
                        break;

                    case 5:
                        Console.WriteLine(userFridge.CheckFoodSupplies()); 
                        break;

                    case 6:
                        Console.WriteLine("The fridge is clean: " + userFridge.IsClean);
                        Console.WriteLine("The type of dispenser: " + userFridge.DispenserType);
                        Console.WriteLine("The amount of foor remaining: " + userFridge.FoodAmount);
                        Console.WriteLine("Do the light bulbs work? " + userFridge.BulbsWork);
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;

                }
            } while ((userChoice != 8) || (userChoice==7));
            if (userChoice == 8)
            {
                Console.WriteLine("You have quit the program.");
            }
        }
    }
}
