using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class HiddenWord
    {
        public string word;
        public string guess;
        public int winPoint;
        int parachuteLeft = 0;
        private TerminalService _terminalService = new TerminalService();
        List<string> jumper = new List<string>();
        List<char> hiddenJumper = new List<char>();
        public HiddenWord(string gameWord)
        {
            jumper.Add("    ___");
            jumper.Add(@"   /   \");
            jumper.Add("   |___|");
            jumper.Add(@"   \   /");
            jumper.Add(@"    \ /");
            jumper.Add("     o");
            jumper.Add(@"    /|\");
            jumper.Add(@"    / \");
            jumper.Add("");
            jumper.Add("");
            jumper.Add("^^^^^^^^^^^^^");
            jumper.Add("");
            word = gameWord;
            foreach (char letter in word)
                {
                    hiddenJumper.Add('_');
                }
        }

/// <summary>
/// Iterates through the list of items making up the person and parachute, printing each one
/// Iterates through the hidden word and prints an '_' for each character 
/// </summary>
        public void drawState()
            {
                foreach (string parachutePiece in jumper)
                    {
                        _terminalService.WriteText(parachutePiece);
                    } 

                foreach (char letter in hiddenJumper)
                    {
                        Console.Write(letter);
                    }

            _terminalService.WriteText("");
            _terminalService.WriteText("");
        }

/// <summary>
/// Compares guess character to characters in word
/// Fills in where the guess matches
/// If no match, turns part of the parachute into an 'x'
/// </summary>
/// <param name="guess"></param>
        public void guessCharacter(char guess)
            {
            int indexListNumber = 0;
            bool incorrectGuess = true;
            foreach (char letter in word)
                {
                    if (letter == guess)
                    {
                        hiddenJumper[indexListNumber] = guess;
                        indexListNumber = indexListNumber + 1;
                        incorrectGuess = false;
                        winPoint = winPoint + 1;
                    }

                    else
                    {
                        indexListNumber = indexListNumber + 1;                     
                    }                
                }
            if (incorrectGuess)
                {
                jumper[parachuteLeft] = "    xxx";
                parachuteLeft = parachuteLeft + 1;
            }
            }

/// <summary>
/// Checks whether the list item at index[4] is 'x' 
/// and returns a value dependent upon whether the game is over
/// </summary>
/// <returns></returns>
        public bool checkGameContinue()
            {
                if (jumper[4] == "    xxx")
                {
                    return false;
                }
                else if (winPoint == word.Length)
                {
                    return false;
                }  

                else
                {
                    return true;
                }
            }
    }
}