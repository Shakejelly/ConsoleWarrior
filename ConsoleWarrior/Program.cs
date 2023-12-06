namespace ConsoleWarrior

{//
    using ConsoleWarrior.Utilities;
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

            Functions.Print("\t\tWelcome to Cånzål Wharrjorz. What is your name?.");
            Console.Write("\t\tUsername: ");
            string userName = Functions.CursorReadLine();
            Console.Clear();
            //Functions.Print($"\t\t\tHello {userName}, you are about to begin your journey. But before that, choose your class.");
            Functions.Print($"\t\tHello {userName}, you are about to begin your journey. But before that, choose your class.");
            string[] classOption = { "\t\tWarrior", "\t\tBowman", "\t\tSorcerer" };
            int playerClass = Functions.OptionsNavigation(classOption, $"\t\tHello {userName}, you are about to begin your journey. But before that, choose your class.");

            switch (playerClass)
            {
                case 0:
                    Functions.Print("\t\tYou have chosen Warrior.");
                    
                     break;
                case 1:
                    Functions.Print("\t\tYou have chosen Bowman.");
                    
                    break;
                case 2:
                    Functions.Print("\t\tYou have chosen Sorcerer");
                    
                    break;
            }
        }
    }
}