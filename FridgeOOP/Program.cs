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
            // Create an interactive console window
            // Prompt user to choose what to do with the fridge
            // Call methods on fridge object to do what the user wants
            int userChoice = 0;
            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true); // this has to be out of the loop otherwise it resets everytime
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1.");
                Console.WriteLine("To change the lightbulb, type 2.");
                Console.WriteLine("To clean, type 3.");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check food supplies, type 5.");
                Console.WriteLine("To see all fridge details, type 6.");
                //Console.WriteLine("To restart, type 7.");
                Console.WriteLine("To quit, type 8.");

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
                        Console.WriteLine("How much food do you want? Please enter number of items.");
                        int usersFood = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(usersFood);
                        break;
                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;
                    case 6:
                        Console.WriteLine("The dispenser type is " + userFridge.DispenserType);
                        Console.WriteLine("It is " + userFridge.BulbsWork + " that the bulbs work.");
                        Console.WriteLine("It is " + userFridge.IsClean + " that the fridge is clean.");
                        Console.WriteLine("The fridge has " + userFridge.FoodAmount + " food items.");
                        break;
                }

            } while (userChoice != 8);

        }
    }
}
