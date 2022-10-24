using System;
namespace Jumper_Idaho
{
        public class TerminalService
    {
        /// Constructs a new instance of TerminalService.
        
        public TerminalService()
        {
        }
        /// Gets numerical input from the terminal. Directs the user with the given prompt.
        public string ReadGuess(string prompt)
        {
            string rawValue = ReadText(prompt);
            return rawValue;
        }
        /// Gets text input from the terminal. Directs the user with the given prompt.
        /// <returns>Inputted text.</returns>
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        /// Displays the given text on the terminal.  
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}