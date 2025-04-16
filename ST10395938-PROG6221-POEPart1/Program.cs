namespace ST10395938_PROG6221_POEPart1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            
            GreetingBase text = new AsciiArt();
            GreetingBase audio = new AudioPlayer();
           
            text.PlayGreeting();
            audio.PlayGreeting();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Welcome to the Cybersecurity Awareness Bot ===");
            Console.WriteLine("1. Start Application");
            Console.WriteLine("2. Exit");
            Console.ResetColor();

            bool validChoice = false;

            while (!validChoice)
            {
                Console.Write("Please enter your choice (1 or 2): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        validChoice = true;
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Thank you! Exiting application...");
                        Console.ResetColor();
                        return; // exits the program

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please enter 1 to start or 2 to exit.");
                        Console.ResetColor();
                        break;
                }
            }

            string userName = TextGreeting.AskUserName();

            
        }
    }
}
