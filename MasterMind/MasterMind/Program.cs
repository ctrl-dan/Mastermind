using System;
using System.Collections.Generic;
using System.Linq;

using MasterMind;

Menu.MainMenu();

char input;
bool exit = false; 

do
{
    input = char.ToLower(Console.ReadKey().KeyChar); //user input
    switch (input) //swtich for selecting options
    {
        case '1':   //New game
            Game.Play();
            Menu.MainMenu();
            break;

        case '2':   //Help
            Menu.Help();
            Menu.MainMenu();
            break;

        case '3':  //Exit
            exit = true; 
            break;

        default:
            Console.WriteLine("\nPlease select one of the available choices.");
            break;
    }
} 
while (exit == false); //menu keeps reappearing until the user chooses to exit


