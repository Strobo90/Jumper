using System;
namespace Jumper_Idaho
{
        public class TerminalService
    {// Constructs  TerminalService.
        public TerminalService()
        {
        }
        public string ReadGuess(string prompt)
        {
            string rawValue = ReadText(prompt);
            return rawValue;
        }
        //Gets text input from the terminal
    
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        // Displays the given text on the terminal.  
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}