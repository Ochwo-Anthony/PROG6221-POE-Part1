using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10395938_PROG6221_POEPart1
{
    public class TextGreeting
    {
      public static string AskUserName()
        {
            string userName = "";
            while (true)
            {


                Console.Write("Please Input your name: ");
                try
                {
                    userName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(userName))
                    {
                        throw new ArgumentException("Name cannot be empty.");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Nice to meet you, {userName}! I'm your Cybersecurity Awareness Bot.");
                    Console.ResetColor();
                    break;
                }

                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Input error: {ex.Message}");
                    Console.ResetColor();
                }
            }

            return userName;
        }

    }
}
