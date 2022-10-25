using System;
using System.Collections.Generic;
namespace Jumper_Idaho
{
    public class parachute{   // creates the pachute class.
        private List<string> Parachute = new List<string>();
        private int count;
        private int trueTries = 0; // tries are intialize to be zero and set as private so that they cant be change # encupsulated

        public parachute() //print the below parachute to the terminal 
        {   Parachute.Add(" ___");
            Parachute.Add("/___\\");
            Parachute.Add("\\   /");
            Parachute.Add(" \\ /");
            Parachute.Add("  O");
            Parachute.Add(" /|\\");
            Parachute.Add(" / \\");
            Parachute.Add("\n !!! Guess wrong You die | \n Guess Smart you live !!!");
        }  // check the inputs of the player 
        public bool checkInput(List<char> guesses, string currentguess){
            if (guesses.Contains(currentguess[0])){
                Console.WriteLine(" OOOPS !! Try another letter!");// if the same guess is made twice print this
                return true;
            } // enter this blockif the above returns a false boolean
            else {
                return false;
            }

        }               // Lets check the number of tries and the Guesses
        public bool checkJumper(List<char> wordGuess, int tries){
            count = 0;
            for(int i=0;i<wordGuess.Count;i++){
                if (wordGuess[i] != '_'){
                    count++;
                }
                else{}
            }
            if (count == wordGuess.Count){
                return false;
                
            }
            else if(tries == 3){ // once the tries equates to 3 return a false value to check jumper and end game
                return false;
            }
            else {
                return true; // if less than 3 tries made . continue trying
            }
        }

        public void printJumper(int tries){
            if (tries == trueTries){

            }
            else if(tries == 4){
                Parachute.RemoveRange(0,1);
                Parachute[0] = "             ?";


            }
            else{
                Parachute.RemoveRange(0,1);
                trueTries++;
            }
            Console.WriteLine(string.Format("{0}", string.Join("\n", Parachute)));
        }
    }
}