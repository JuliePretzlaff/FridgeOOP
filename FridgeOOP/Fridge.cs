using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge
    {
        //fields
        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;


        //Properties
        public bool IsClean
            {
                get { return this.isClean; }
                set { this.isClean = value; }
            }

        public string DispenserType
            {
                get { return this.dispenserType; }
            }
    
        public int FoodAmount
            {
                get { return this.foodAmount; }
                set { this.foodAmount = value; }
            }

        public bool BulbsWork
            {
                get { return this.bulbsWork; }
                set { this.bulbsWork = value; }
            }
        
        //Constructors
        public Fridge()
        {
            this.dispenserType = "basic water dispenser";//this ensures every fridge instantiated will have this value for dispenserType
            //this is the default constructor
        }


        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType; //first one is field, second one paramenter(in paranthese above);
        }//the parameter is bypassing the property (which doesn't have a set) and going directly to the field, even though it's private (b/c the constructor is public)
        
   
        public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }

        //Methods() 
        //a way to dispense water
        public void DispenseWater()
        {
            if (dispenserType == "basic water dispenser")
            {
                Console.WriteLine("Here is some lukewarm water!");
            }
            else if(dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("Enjoy your perfect ice water!");
            }
            else
            {
                Console.WriteLine("What's gonna come out?  It's a surprise!");
            }

            //
        }
    }
}
