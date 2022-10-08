using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 300;
        Card card;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            card = new Card();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to draw.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Draw card? [y/n] ");
            string drawCard = Console.ReadLine();
            _isPlaying = (drawCard.ToLower() == "y");
            Console.Write($"Your current point score is: {_totalScore}\n");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _score = 0;

            card.drawCard();
            _score = card.points;
            _totalScore += _score;
        }

        /// <summary>
        /// Displays the next card and the scores. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"The next card was: {card.nextCardNumber}");
            Console.WriteLine($"You received: {_score}");
            Console.WriteLine($"Your score is: {_totalScore}\n");

            _isPlaying = (_totalScore > 0);
        }
    }
}