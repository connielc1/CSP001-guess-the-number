using System;

namespace CSP001_guess_the_number
{
    class Player
    {
        public string Name { get; }
        public int LastGuess { get; set; }

        public Player(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "El nombre no puede ser nulo.");
            LastGuess = 0;
        }

        public void MakeGuess()
        {
            Console.WriteLine($"{Name}, por favor ingresa el posible número:");
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Error: Se ha producido un problema al leer la entrada.");
                return;
            }
            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Por favor, ingresa un número válido:");
                MakeGuess();
                return;
            }

            LastGuess = guess;
        }
    }
}
