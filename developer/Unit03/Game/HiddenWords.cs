using System;
using System.Collections.Generic;
using System.IO;

namespace Unit03.Game
{
    public class HiddenWord{
        public string hiddenword;
        List<char> answer = new List<char>();
        public List<char> guess = new List<char>();
        
        // Creates a new instance of HiddenWord
        public HiddenWord()
        {   
        }

        // Get the word from the txt file OK
        public string pullWord(){
            List<string> lines = new List<string>(File.ReadLines("sample.txt"));
            Random rand = new Random();
            int randomIndex = rand.Next(0, lines.Count);
            string chosenWord = lines[randomIndex];
            return chosenWord;
        }

        // Use a word as a parameter. Add the answer to the list and convert to lower
        public void listWord(string ripWord){
            answer.AddRange(ripWord.ToLower());
        }

        // Create lines for the hidden word
        public void createHiddenWord(){
            foreach (int i in answer){
                guess.Add('_');
            }
            }

        // Print the guess of the user.
        public void printGuess(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", guess)));       
        }

        // Verify if the guess is in the hidden word and compare the list of previous guesses with the number of guesses.
        public int compare(List<char> listPreviousGuesses, int numberOfGuesses){
            for(int i=0;i<answer.Count;i++){
                if (listPreviousGuesses.Contains(answer[i])){
                    guess[i] = answer[i];}}
            if (answer.Contains(listPreviousGuesses[numberOfGuesses-1])){
                return 0;}
            else {
                return 1;}
        }

        // Print the hidden word.
        public void printAnswer(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", answer)));
        }
    };
}