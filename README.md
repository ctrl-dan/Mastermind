# Mastermind
Mastermind Game written in C# for Quadax

The game can be run from Visual Studio by launching through the MasterMind.sln or MasterMind.csproj or through the .exe file here: [Mastermind.exe](MasterMind/MasterMind/bin/Debug/net8.0/MasterMind.exe)

The game contains a menu screen where the options include
1. New Game
2. Help
3. Exit

![mastermind2](https://github.com/user-attachments/assets/20ffd242-01ea-4e83-9636-ecc711c012cf)

New Game starts a new game of Mastermind
Help explains the rules
Exit closes the game

When New Game is selected, the code does the following:
1. Generates a new random number 4 digits in length with values from 1-6
2. Prompts the User for input
3. Validates user input is correctly formatted and, if not, reprompts the user
4. Converts the input string into an int array once validated
5. Calls the "CheckInput" Function
6. Checks for numbers in the correct position
7. Checks for numbers that are correct but in an incorrect position
8. Returns a string indicating that the user input is correct or a string with '+' and '-' to show feedback
9. Loops through this game loop until the user wins or runs out of guesses and loses

![mastermind1](https://github.com/user-attachments/assets/ceae2569-0536-460e-9745-b11671fb3213)


CheckInput function sets the target number created by the computer to a temp int array that is used to deal with inconsistencies when double numbers are present.
This is done by checking for the correct position, and if it is correct, then setting that value to 0.
This 0 in the temp array allows for when checking for the correct number, but in the wrong position, so that a number is not counted twice.
