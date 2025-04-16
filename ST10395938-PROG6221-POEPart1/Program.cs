namespace ST10395938_PROG6221_POEPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GreetingBase text = new AsciiArt();
            GreetingBase audio = new AudioPlayer();
           
            text.PlayGreeting();
            audio.PlayGreeting();

            Console.WriteLine("\nWelcome to the Cybersecurity Awareness Bot!");

        }
    }
}
