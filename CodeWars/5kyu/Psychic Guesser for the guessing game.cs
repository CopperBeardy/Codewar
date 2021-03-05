using System;

public class PsychicGuesser
{
    public int lastguess = 0;
    public int Upperlimit = 1000;
    public int Lowerlimit = 0;
    public int guess = 0;

    // -1 0 1
    public int MakeAGuess(int lastResult)
    {
        if(guess != 0)
        {
            if(lastResult == 1)
            {
                Upperlimit = lastguess;
                lastguess = (int)Math.Ceiling(Upperlimit - Lowerlimit / 2.0) / 2;
                guess++;

                return lastguess;

            } else if(lastResult == -1)
            {
                Lowerlimit = lastguess;
                lastguess = (int)Math.Ceiling(Upperlimit - Lowerlimit / 2.0) ;
                guess++;

                return lastguess;
            }
        } else
        {
            lastguess = (int)Math.Ceiling(Upperlimit - Lowerlimit / 2.0)/2;
            guess++;

            return lastguess;

        }


        return lastguess;

    }




  public void Solve() 
    {
        var result = PlayTheGuessingGame();
        Console.WriteLine(result);
    }
    private int PlayTheGuessingGame()
    {
        var guesser = new PsychicGuesser();
        var game = new GuessingGame();
        var lastResult = -1;
        while (lastResult != 0)
        {
            lastResult = game.Guess(guesser.MakeAGuess(lastResult));
        }
        return game.Guesses;
    }

    public sealed class GuessingGame
    {
        private static readonly Random random = new Random();
        private const int MaxGuesses = 10;

        private readonly int secretNumber;

        public int Guesses { get; private set; }

        public GuessingGame()
        {
            secretNumber = random.Next(0, 1000);
            Guesses = 0;
        }


        public int Guess(int number)
        {
            Guesses++;

            if (Guesses > MaxGuesses) throw new InvalidOperationException("Game over!");

            if (number == secretNumber)
            {
                Console.WriteLine("You guessed correctly!");
                return 0;
            }

            if (number <= secretNumber)
            {
                Console.WriteLine("Too small!");
                return -1;
            }
            else
            {
                Console.WriteLine("Too big!");
                return 1;
            }
        }
    }
}