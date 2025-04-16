using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace ST10395938_PROG6221_POEPart1
{
    internal class AudioPlayer : GreetingBase
    {
        public override void PlayGreeting()
        {
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "AudioGreeting.wav");

            try
            {
                SoundPlayer player = new SoundPlayer(audioPath);
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Audio Error: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
