using System;


namespace Unit02.Game
{
        /// <summary>
        /// A random card pulled from a standard deck, ranging from 1 to 13 in values.
        /// 
        /// The responsibility of Card is to keep track of its current value and the points it's
        /// worth.
        /// </summary> 
    public class Card
    {
        public int cardNumber;
        public int nextCardNumber;
        public int points; 

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
            cardNumber = 1;
            points = 0;
        }
    
        /// <summary>
        /// Generates a new random value and calculates the points for the card. Correct guess is +100 points. Incorrect guess is -75 points.
        /// </summary>
        public void drawCard()
        {
            nextCardNumber = new Random().Next(1, 14);

            Console.WriteLine($"Your card is {cardNumber}");
            Console.WriteLine("Is the next card higher or lower? [h/l]");
            string guess = Console.ReadLine();

            if (guess == "h")
            {
                if (cardNumber < nextCardNumber)
                {
                    points = 100;
                }

                else if (cardNumber > nextCardNumber)
                {
                    points = -75;
                }
            }
            
            else if (guess == "l")
            {
                if (cardNumber < nextCardNumber)
                {
                    points = -75;
                }

                else if (cardNumber > nextCardNumber)
                {
                    points = 100;
                }
            }

            else
            {
                points = 0;
            }
            cardNumber = nextCardNumber;
        }
    }
}