using System;
using System.Collections.Generic;

namespace Jumper_Idaho
{       public class Game       // creates the Game class
    {        private bool isPlaying = true; // Private key word encupsulates is playing boolean
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
        public Game() // call to the Game function. call is publicly accessible
        {
        }
        public void StartGame() // 
        {
            StartUp(); // if is playing give a true value  call the below function in the block in their order
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
                private void StartUp()// calls stattup and this is encupsulated by private keyword. It does returnany value. ... void
        {
            Console.WriteLine("\n The Names of the Buildings at BYU- Idaho");// prints to console
            chosenWord = hiddenWord.pullWord();
            hiddenWord.listWord(chosenWord);
            hiddenWord.createHiddenWord();
            hiddenWord.printGuess();
        }
        private void GetInputs()// call this function
        {
            Console.WriteLine("\n");
            parachute.printJumper(tries);
            checkInput = true;// accesses the player input and checks if it is on the sample txt doc
            while (checkInput){ // if checkinput is true  execute the below statements
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
            }// enter this block if the above if statement is false
            else {
                parachute.printJumper(tries);
                hiddenWord.printAnswer();
                Console.WriteLine("\n");
            }
  
        }
    }
}
