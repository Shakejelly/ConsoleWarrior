using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWarrior.Utilities
{
    internal class Functions
    {
        public static void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
        public static string CursorReadLine()
        {
            string input;
            Console.CursorVisible = true;
            input = Console.ReadLine();
            Console.CursorVisible = false;
            return input;
        }
        public static int OptionsNavigation(string[] options, string phrase)
        {
            int menuSelection = 0;

            // Loops until user presses enter on a choice
            while (true)
            {
                // Clears window and re-prints the sent in phrase on each loop
                Console.Clear();
                Console.WriteLine(phrase);

                // Forloop to print all the options 
                for (int i = 0; i < options.Length; i++)
                {
                    // Changes color of the option we've currently selected so when menuSelection is for exemple "2" the second option will turn darkgrey
                    if (i == menuSelection)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }

                    // Prints all the options in the array along with the pointer arrow if on the current selection
                    Console.Write($"{options[i]}{(menuSelection == i ? " <--" : "")}\n");

                    // Reset color to default
                    Console.ResetColor();
                }

                //"Listen" to keystrokes from the user
                ConsoleKeyInfo key = Console.ReadKey(true);

                //Handles the arrow keys to move up and down the menu
                if (key.Key == ConsoleKey.UpArrow && menuSelection > 0)
                {
                    menuSelection--;
                }
                else if (key.Key == ConsoleKey.DownArrow && menuSelection < options.Length - 1)
                {
                    menuSelection++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    return menuSelection;
                }
            }
        }
    }
}

