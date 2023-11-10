namespace ConsoleWarrior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Welcome to Cånzål Wharrjorz. Choose a username.");
            string userName = Console.ReadLine();
            Console.Clear();
            Print($"Hello {userName}, you are about to begin your journey. But before that, choose your class.");
            Console.WriteLine("1. Warrior\t\t\t2. Bowman\t\t\t3. Sorcerer");

            string playerClass = Console.ReadLine();

            switch (playerClass)
            {
                case "1":
                    Print("You have chosen Warrior.");
                    playerClass = "Warrior";
                     break;
                    case "2":
                    Print("You have chosen Bowman.");
                    playerClass = "Bowman";
                    break;
                    case "3":
                    Print("You have chosen Sorcerer");
                    playerClass = "Sorcerer";
                    break;
            }
            
            
                

        }
        public static void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
   
}