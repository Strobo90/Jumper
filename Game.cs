using System;
using System.Collections.Generic;

namespace Jumper_Idaho
{       public class Game
    {

        private bool isPlaying = true;
        private string chosenWord;

        private TerminalService terminalService = new TerminalService();
        public word hiddenWord = new word();
        private parachute parachute = new parachute();
        public int tries = 0;
        public int numberOfGuesses = 0;

        private bool checkInput;

        List<char> guessedLetters = new List<char>();

        public string currentGuess = "test";


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Game()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            StartUp();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }


        private void StartUp()
        {
            Console.WriteLine("\n The Names of the Buildings at BYU- Idaho");
            chosenWord = hiddenWord.pullWord();
            hiddenWord.listWord(chosenWord);
            hiddenWord.createHiddenWord();
            hiddenWord.printGuess();
        }
        private void GetInputs()
        {
            Console.WriteLine("\n");
            parachute.printJumper(tries);
            checkInput = true;
            while (checkInput){
                currentGuess = terminalService.ReadGuess("\n Now Make an Educated Guess.Which letter of the Alphabet do you pick \n Choosing the same letter twice is not allowed. \n Shoot Your shot===>>>: ");
                checkInput = parachute.checkInput(guessedLetters, currentGuess);
            }
            guessedLetters.Add(currentGuess[0]);
            

        }


        private void DoUpdates()
        {
            numberOfGuesses = guessedLetters.Count;
            int usedTries = hiddenWord.compare(guessedLetters, numberOfGuesses);
            tries = tries + usedTries;
            isPlaying = parachute.checkJumper(hiddenWord.guess, tries);
        }


        private void DoOutputs()
        {
            Console.WriteLine("\n");
            if (isPlaying){
                hiddenWord.printGuess();
            }
            else {
                parachute.printJumper(tries);
                hiddenWord.printAnswer();
                Console.WriteLine("\n");
            }
  
        }
    }
}
