using System;
using System.Collections.Generic;
using System.Linq;

using MasterMind;

Menus.MainMenu();

char input;
bool exit = false; 

do
{
    input = char.ToLower(Console.ReadKey().KeyChar); //user input
    switch (input) //switch for selecting options
    {
        case '1':   //Start Game
            Game.GameStart();
            Menus.MainMenu();
            break;

        case '2':   //Help
            Menus.Help();
            Menus.MainMenu();
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


