using System;

namespace CSP001_guess_the_number
{
    class Player
    {
        public string Name { get; }
        public int LastGuess { get; private set; }

        public Player(string name)
        {
            Name = name;
            LastGuess = 0;
        }

        public void MakeGuess()
        {
            Console.WriteLine($"{Name}, por favor ingresa el posible número:");
            string? input = Console.ReadLine();
            int guess;

            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Por favor, ingresa un número válido:");
                input = Console.ReadLine();
            }

            if (int.TryParse(input, out guess))
            {
                LastGuess = guess;
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                MakeGuess();
            }
        }
    }
}
