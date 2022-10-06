using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
    public class Card
    {
        public int cardNumber;
        public int nextCardNumber;
        public int points; 

    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
            cardNumber = new Random().Next(1, 14);
            nextCardNumber = new Random().Next(1, 14);
            points = 0;
        }
    
    // 3) Create the drawCard() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the card. Correct guess is +100 points. Incorrect guess is -75 points.
        /// </summary>
        public void drawCard()
        {

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
        }
    }
}