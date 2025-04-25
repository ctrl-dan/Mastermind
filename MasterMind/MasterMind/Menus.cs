using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    public class Menus
    {
        public static void MainMenu() //shows the main menu
        {
            Console.Clear();
            Console.WriteLine("\nWelcome to...");
            Console.WriteLine();
            Console.WriteLine("___  ___          _                      _           _ \r\n|  \\/  |         | |                    (_)         | |\r\n| .  . | __ _ ___| |_ ___ _ __ _ __ ___  _ _ __   __| |\r\n| |\\/| |/ _` / __| __/ _ \\ '__| '_ ` _ \\| | '_ \\ / _` |\r\n| |  | | (_| \\__ \\ ||  __/ |  | | | | | | | | | | (_| |\r\n\\_|  |_/\\__,_|___/\\__\\___|_|  |_| |_| |_|_|_| |_|\\__,_|\r\n                                                       \r\n                                                       ");
            Console.WriteLine("Press '1' for New Game");
            Console.WriteLine("Press '2' for Help");
            Console.WriteLine("Press '3' to Exit the Game");
        }

        public static void Help() //shows help screen
        {
            Console.Clear();
            Console.WriteLine("Rules: ");
            Console.WriteLine("The computer will generate a random 4 digit number.");
            Console.WriteLine("Each digit is between 1 and 6.");
            Console.WriteLine("You have 10 tries to guess the number.");
            Console.WriteLine("After each guess, you will recieve feeback:");
            Console.WriteLine("A '+' means your guess was correct in one of the four positions.");
            Console.WriteLine("A '-' means that one of your digits is in the number, but not in the corrrect position.");
            Console.WriteLine();
            Console.WriteLine("Press any other key to return to the main menu");

            char charHelp; //saves the key for navigation
            charHelp = char.ToLower(Console.ReadKey().KeyChar); //user input

        }
    }
}