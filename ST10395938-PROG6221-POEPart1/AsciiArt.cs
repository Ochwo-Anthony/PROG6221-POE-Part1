using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10395938_PROG6221_POEPart1
{
    internal class AsciiArt : GreetingBase
    {
        public override void PlayGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  _______     ______  ______ _____  ____   ____ _______ _  
  / ____\ \   / /  _ \|  ____|  __ \|  _ \ / __ \__   __| | 
 | |     \ \_/ /| |_) | |__  | |__) | |_) | |  | | | |  | | 
 | |      \   / |  _ <|  __| |  _  /|  _ <| |  | | | |  | | 
 | |____   | |  | |_) | |____| | \ \| |_) | |__| | | |  |_| 
  \_____|  |_|  |____/|______|_|  \_\____/ \____/  |_|  (_) 
");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("                     A Cyber Security Chabot");
            Console.ResetColor();
        }
    }
}
