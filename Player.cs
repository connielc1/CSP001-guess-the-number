using System;

namespace CSP001_guess_the_number
{
    class Player
    {
        public string Name { get; }
        public int LastGuess { get; set; }

        public Player(string name)
        {
            Name = name ?? throw new ArgumentException("El nombre no puede ser nulo.", nameof(name));
            LastGuess = 0;
        }
    }
}
