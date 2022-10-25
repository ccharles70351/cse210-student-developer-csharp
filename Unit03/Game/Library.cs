using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Library
    {
        public string hiddenWord;
        public Library()
        {
        }

        public string getWord(string difficulty)
            {
                if (difficulty == "h")
                {;
                    Random r = new Random();
                    string[] words = {"ox", "lithium", "ion", "dweeb"};
                    hiddenWord = words[r.Next(0, words.Length)];
                    return hiddenWord;
                }

                else
                {
                    Random r = new Random();
                    string[] words = {"apple", "orange", "banana", "kiwi"};
                    hiddenWord = words[r.Next(0, words.Length)];
                    return hiddenWord;
                }
                
            }
    }
}