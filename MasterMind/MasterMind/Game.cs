using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MasterMind
{
    internal class Game
    {
        private static int[] GenerateNum()
        {
            //generates random 4 digit number between 1-6
            var rand = new Random();
            int[] randomNumber = new int[4];
            for (int i = 0; i < 4; i++)
            {
                randomNumber[i] = rand.Next(1, 7);
            }
            return randomNumber;
        }

        static bool IsValidInput(int[] input)
        {
            if (input.Length != 4) // Check if the array has exactly 4 elements
            {
                return false;
            }

            foreach (int digit in input) // Loop through each digit
            {
                if (digit < 1 || digit > 6) // Check if digit is in range 1–6
                {
                    return false;
                }
            }

            return true; // All checks passed
        }

        public static string CheckInput(int [] userInput, int[] target)
        {
            int correctNumber = 0;
            int correctPosition = 0;
            string exitString = "";
            int[] temp = new int[4];

            for (int i = 0; i < target.Length; i++) //sets the temp array to the target number
            {
                temp[i] = target[i];
            }

            for (int i = 0; i < 4; i++) //checks the user input for correct positions and if found sets that value to 0 in temp array
            {
                if (target[i] == userInput[i])
                {
                    correctPosition++;
                    temp[i] = 0;
                }

            }

            for (int i = 0; i < 4; i++) //checks for correct number but wrong spot
            {
                if (temp[i] == 0) //checks for 0 in temp array to see if position is correct and if not checks if the number is in the rest of the target
                {
                    continue;
                }

                if ((temp.Contains(userInput[i])) && (temp[i] != userInput[i])) //temp set to 0 to avoid duplicate numbers in target string giving mulitple '-'
                {
                    correctNumber++;
                    continue;
                }


            }

            if (correctPosition == 4) //checks if number is completely correct
            {
                return "Correct";
            }
            else //builds exit string of '+' and '-' and returns
            {
                for (int i = 0; i < correctPosition; i++)
                {
                    exitString = exitString + "+";
                }
                for (int i = 0; i < correctNumber; i++)
                {
                    exitString = exitString + "-";
                }
                return exitString;
            }

        }
        
        public static void GameStart()
        {

            //makes target number
            int[] target = GenerateNum();
            string result = string.Join("", target);

            //prompts user for input
            Console.Clear(); 
            Console.WriteLine("Enter your guess:");

            int count = 0;
            while (true) //while user has not won or lost
            {
                //recieves user input and checks if it is valid (contains 1-6, and 4 digits)
                string input = Console.ReadLine();
                int[] userInput = input.Select(v => v - '0').ToArray(); //converts input to array
                bool isValid = IsValidInput(userInput);

                while(!isValid) //keep prompting user until correctly formatted input
                {
                    Console.WriteLine("\nThe entered number must contain digits 1-6 and be 4 characters");
                    Console.WriteLine("Enter another guess:\n");
                    input = Console.ReadLine();
                    userInput = input.Select(v => v - '0').ToArray(); //converts input to array
                    isValid = IsValidInput(userInput);
                }
                count++;

                userInput = input.Select(v => v - '0').ToArray(); //makes sure that userInput is up to date
                string response = CheckInput(userInput, target); //calls function to check input

                if(response == "Correct") //if completely correct then user win
                {
                    Console.WriteLine("You Win! Number of count: {0}. Press any key to return to the main menu.", count);
                    Console.ReadKey();
                    break;
                }
                else if(response != "Correct" && count == 10) //user is out of attempts
                {
                    Console.WriteLine("\nYou Lose! The number was {0}. Press any key to return to the main menu.", result);
                    Console.ReadKey();
                    break;
                }
                else //if not correct show '+' and '-' and number of attempts remaining
                {
                    Console.WriteLine(response);
                    Console.WriteLine("\nYou have {0} count remaining", (10 - count));
                    Console.WriteLine("Enter your next guess:\n");
                }
                
            }
        }
    }
}