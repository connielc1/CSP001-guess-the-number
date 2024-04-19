using System;

namespace CSP001_guess_the_number
{
    class Player
    {
        public string Name { get; }
        private int lastGuess;

        public Player(string name)
        {
            Name = name ?? throw new ArgumentException("El nombre no puede ser nulo.", nameof(name));
            lastGuess = 0;
        }

        public int GetLastGuess()
        {
            return lastGuess;
        }

        public void SetLastGuess(int guess)
        {
            lastGuess = guess;
        }
    }
}
