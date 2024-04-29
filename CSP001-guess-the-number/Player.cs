using System;
using System.Collections.Generic;

namespace CSP001_guess_the_number
{
    abstract class Player
    {
        public string Name { get; }
        protected List<int> guesses;

        protected Player(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "El nombre no puede ser nulo.");
            guesses = new List<int>();
        }

        public abstract int MakeGuess();
        
        public void AddGuess(int guess)
        {
            guesses.Add(guess);
        }

        public List<int> GetGuesses()
        {
            return guesses;
        }
    }

    class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override int MakeGuess()
        {
            Console.WriteLine("Ingresa tu número:");
            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Por favor, ingresa un número válido:");
                return MakeGuess();
            }

            return guess;
        }
    }

    class AIPlayer : Player
    {
        private readonly Random random;

        public AIPlayer(string name) : base(name)
        {
            random = new Random();
        }

        public override int MakeGuess()
        {
            int guess = random.Next(1, 101);
            AddGuess(guess);
            return guess;
        }
    }
}
