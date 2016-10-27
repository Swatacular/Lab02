using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {

            string bread;
            string cheese = "no";
            string meat = "no";
            string veggies = "no veggies";
            string toasted = "";
            string sauce = "no sauce";

            int gameState = 1; //Inital Scene is scene 1
            while (!(gameState == 0))
            {
                switch (gameState)
                {
                    case 1:
                        Console.WriteLine("Hello and welcome to the gas station!");
                        Console.WriteLine("Would you like to go inside to Subway or get gas?");

                        if (!(GetBoolInput())) gameState = 2; // I don't need {} here because I only want to execute one line of code.
                        else gameState = 3;

                        break;

                    case 2:
                        Console.WriteLine("Ok, you go pay the total for the gas and then leave.");
                        gameState = 0; //scene 0 ends the game.
                        break;

                    case 3:
                        Console.WriteLine("You walk into the gas station and walk over to the subway");
                        Console.WriteLine("Do you want a sub?");
                        if (!(GetBoolInput())) gameState = 2;
                        else gameState = 4;
                        break;

                    case 4:
                        Console.WriteLine("What kind of bread to you want?");
                        Console.WriteLine("There is Italian, 5-Grain, Cheese, and Honeyoat.");
                        bread = GetBreadType();
                        Console.WriteLine();
                        Console.WriteLine("Your " + toasted + "sub currently has:");
                        Console.WriteLine(bread + " bread, " + meat + ", " + cheese + " cheese, " + veggies + " and " + sauce);
                        gameState = 5;
                        break;
                    case 5:
                        Console.WriteLine("What kind of meat to you want?");
                        Console.WriteLine("There is Italian, Chicken, Cheese, and Honeyoat.");
                        bread = GetBreadType();
                        Console.WriteLine();
                        Console.WriteLine("Your " + toasted + "sub currently has:");
                        Console.WriteLine(bread + " bread, " + meat + ", " + cheese + " cheese, " + veggies + " and " + sauce);
                        gameState = 6;
                        break;

                    default:
                        Console.WriteLine("Sorry, there is no scene #" + gameState + ". Resetting game.");
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        gameState = 1;
                        Console.Clear();
                        break;


                } //end of scenes (switch)


            } //end of loop
            Console.ReadKey();


        } //end of main class
        ///////////////////////////////////////////////////////// Yes/No ////////////////////////////////////////////////
        static bool GetBoolInput()
        {
            string input;
            while (true)
            {
                Console.Write("Answer: ");
                input = Console.ReadLine();
                if (input.ToLower() == "y" || input.ToLower() == "yes") return true;
                else if (input.ToLower() == "n" || input.ToLower() == "no") return false;
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry I do not understand your answer. Please try again.");

                }
            }
        }
        ///////////////////////////////////////////////////////// Yes/No ////////////////////////////////////////////////
        ///////////////////////////////////////////////////////// BREAD /////////////////////////////////////////////////
        static string GetBreadType()
        {
            string input;
            while (true)
            {
                Console.Write("Answer: ");
                input = Console.ReadLine();
                switch (input)
                {

                    //different ways to say Italian
                    case "Italian":
                    case "italian":
                    case "i":
                    case "I":
                        return "Italian";
                    
                    //different ways to say 5-Grain
                    case "5-Grain":
                    case "5-grain":
                    case "5grain":
                    case "5Grain":
                    case "5":
                    case "5g":
                    case "5G":
                        return "5-grain wheat";

                    //different ways of saying Cheese
                    case "Cheese":
                    case "cheese":
                    case "c":
                    case "C":
                        return "Cheese";

                    //different ways of saying Honeyoat
                    case "Honeyoat":
                    case "honeyoat":
                    case "h":
                    case "H":
                        return "Honeyoat";

                    //breaks are unnessacary due to "returning" a value

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Sorry I do not understand your answer. Please try again.");
                        break;
                }
            }
        }
        ///////////////////////////////////////////////////////// Bread ////////////////////////////////////////////////
        ///////////////////////////////////////////////////////// Meat ////////////////////////////////////////////////
        static string GetMeatType()
        {
            string input;
            while (true)
            {
                Console.Write("Answer: ");
                input = Console.ReadLine();
                switch (input)
                {

                    //different ways to say Italian
                    case "Italian":
                        return "italian meat";
                    case "italian":
                        return "italian meat";
                    case "i":
                        return "italian meat";
                    case "I":
                        return "italian meat";

                    //different ways to say Turkey
                    case "Turkey":
                        return "turkey";
                    case "turkey":
                        return "turkey";
                    case "T":
                        return "turkey";
                    case "t":
                        return "turkey";

                    //different ways of saying Cheese
                    case "Chicken":
                        return "chicken";
                    case "chicken":
                        return "chicken";
                    case "c":
                        return "chicken";
                    case "C":
                        return "chicken";

                    //different ways of saying Honeyoat
                    case "Ham":
                        return "ham";
                    case "ham":
                        return "ham";
                    case "h":
                        return "ham";
                    case "H":
                        return "ham";

                    //breaks are unnessacary due to "returning" a value

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Sorry I do not understand your answer. Please try again.");
                        break;
                }
            }
        }
        ///////////////////////////////////////////////////////// Meat ////////////////////////////////////////////////
        ///////////////////////////////////////////////////////// Cheese ////////////////////////////////////////////////

        ///////////////////////////////////////////////////////// Cheese ////////////////////////////////////////////////
        ///////////////////////////////////////////////////////// Toasted ////////////////////////////////////////////////

        ///////////////////////////////////////////////////////// Toasted ////////////////////////////////////////////////
        ///////////////////////////////////////////////////////// Veggies ////////////////////////////////////////////////

        ///////////////////////////////////////////////////////// Veggies ////////////////////////////////////////////////
    } //end of namespace
}

