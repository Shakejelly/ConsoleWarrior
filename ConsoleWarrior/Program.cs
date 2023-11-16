namespace ConsoleWarrior
    
{
    using ConsoleWarrior.Utilities;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Functions.Print("\t\t\tWelcome to Cånzål Wharrjorz. Choose a username.");
            Console.Write("\t\t\t");
            string userName = Functions.CursorReadLine();
            Console.Clear();
            //Functions.Print($"\t\t\tHello {userName}, you are about to begin your journey. But before that, choose your class.");
            
            string[] classOption = { "Warrior", "Bowman", "Sorcerer" };
            int playerClass = Functions.OptionsNavigation(classOption,$"\t\t\tHello {userName}, you are about to begin your journey. But before that, choose your class.");

            switch (playerClass)
            {
                case 1:
                    Functions.Print("\t\t\tYou have chosen Warrior.");
                    
                     break;
                case 2:
                    Functions.Print("\t\t\tYou have chosen Bowman.");
                    
                    break;
                case 3:
                    Functions.Print("\t\t\tYou have chosen Sorcerer");
                    
                    break;
            }
        }
    }
}