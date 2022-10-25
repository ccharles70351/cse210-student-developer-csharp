using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Library
    {
        public string hiddenWord;
        public Library()
        {
        hiddenWord = "Banana";
        }

        public string getWord(string difficulty)
            {
                if (difficulty == "h")
                {
                    hiddenWord = "Apple";
                    return hiddenWord;
                }

                else
                {
                    hiddenWord = "Orange";
                    return hiddenWord;
                }
                
            }
    }
}