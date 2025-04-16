using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10395938_PROG6221_POEPart1
{
    internal class ResponseSystem
    {
        public static void StartInteraction(string userName)
        {
         



            while (true)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.Write("\nAsk me something: ");
                Console.ResetColor();

                string userInput = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"I didn't quite understand that, {userName}. Could you rephrase?");
                    Console.ResetColor();
                    continue;
                }

                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string('*', 80));
                    Console.WriteLine(@"

            .-'''-.        .-'''-.                                                         
           '   _    \     '   _    \ _______                                               
         /   /` '.   \  /   /` '.   \\  ___ `'.   /|                        __.....__      
  .--./).   |     \  ' .   |     \  ' ' |--.\  \  ||    .-.          .- .-''         '.    
 /.''\\ |   '      |  '|   '      |  '| |    \  ' ||     \ \        / //     .-''""'-.  `.  
| |  | |\    \     / / \    \     / / | |     |  '||  __  \ \      / //     /________\   \ 
 \`-' /  `.   ` ..' /   `.   ` ..' /  | |     |  |||/'__ '.\ \    / / |                  | 
 /(""'`      '-...-'`       '-...-'`   | |     ' .'|:/`  '. '\ \  / /  \    .-------------' 
 \ '---.                              | |___.' /' ||     | | \ `  /    \    '-.____...---. 
  /'""""'.\                            /_______.'/  ||\    / '  \  /      `.             .'  
 ||     ||                           \_______|/   |/\'..' /   / /         `''-...... -'    
 \'. __//                                         '  `'-'`|`-' /                           
  `'---'                                                   '..'                            
  
");
                    Console.WriteLine($"          Thank you, {userName}! Stay safe online! 😊");
                    Console.WriteLine(new string('*', 80));
                    Console.ResetColor();
                    break;
                }

                string response = GetResponse(userInput, userName);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(response);
                Console.ResetColor();
            }
        }

        private static string GetResponse(string input, string userName)
        {
            try
            {
                if (input.Contains("how are you"))
                    return $"I'm doing well, {userName}! 😊 Ready to help you stay secure online.";

                else if (input.Contains("your purpose"))
                    return "I'm your cybersecurity buddy — here to educate and protect you online.";

                else if (input.Contains("what can i ask") || input.Contains("help"))
                    return "You can ask me about:\n- Password safety\n- Phishing attacks\n- 2FA (Two-Factor Authentication)\n- Social media privacy\n- Safe browsing habits\n- Antivirus and firewalls";

                else if (input.Contains("password"))
                    return "Use strong passwords with a mix of uppercase, lowercase, numbers, and symbols. Don’t reuse them — try a password manager.";

                else if (input.Contains("phishing"))
                    return "Phishing is a scam to steal your info. Never click suspicious links or give out your login credentials by email.";

                else if (input.Contains("safe browsing"))
                    return "Browse safely by updating your browser regularly and avoiding sketchy websites. Use HTTPS when possible!";

                else if (input.Contains("2fa") || input.Contains("two-factor"))
                    return "2FA adds an extra layer of protection. Even if someone gets your password, they can't log in without the code from your phone.";

                else if (input.Contains("social media"))
                    return "Be cautious! Don’t overshare. Lock down your privacy settings and avoid posting personal details publicly.";

                else if (input.Contains("firewall") || input.Contains("antivirus"))
                    return "A good antivirus and firewall help keep your device secure from malware, viruses, and unauthorized access.";

                else if (input.Contains("cloud"))
                    return "Cloud services are convenient, but always protect your accounts with strong passwords and enable 2FA.";


               
                string[] fallbackResponses = {
                    $"Hmm, I'm not sure about that, {userName}. Try asking something like 'What is phishing?' or 'Tips for safe browsing'.",
                    $"Interesting question! I may need an update to answer that one 😅",
                    $"That's outside my expertise, {userName}. But I'm always learning!",
                    $"Cybersecurity is broad! Try narrowing your question to something like passwords, scams, or privacy.",
                };
                Random rand = new Random();
                return fallbackResponses[rand.Next(fallbackResponses.Length)];
            }
            catch (Exception ex)
            {
                return $"Oops! Something went wrong: {ex.Message}";
            }


        }
    }
}
