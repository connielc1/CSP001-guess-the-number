using System;

namespace CSP001_guess_the_number
{
    class Game
    {
        private readonly Player player;
        private readonly int secretNumber;

        public Game(string playerName)
        {
            if (string.IsNullOrEmpty(playerName))
            {
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(playerName));
            }

            player = new Player(playerName);
            secretNumber = new Random().Next(1, 101);
        }

        public void Play()
        {
            Console.WriteLine("Bienvenidx al juego de adivinar el número :)");
            Console.WriteLine($"Hola, {player.Name}. Adivina el número secreto entre 1 y 100:");

            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Error: Se ha producido un problema al leer la entrada. Reinicia el programa e intenta de nuevo.");
                    return;
                }
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Por favor, ingresa un número válido:");
                    continue;
                }

                player.LastGuess = guess;

                if (player.LastGuess == secretNumber)
                {
                    Console.WriteLine("¡Felicidades! ¡Has adivinado el número secreto!");
                    break;
                }
                else if (player.LastGuess < secretNumber)
                {
                    Console.WriteLine("El número secreto es mayor.");
                }
                else
                {
                    Console.WriteLine("El número secreto es menor.");
                }

                // Verificar si el jugador desea continuar jugando
                Console.WriteLine("¿Quieres intentarlo de nuevo? (Sí/No)");
                string? answer = Console.ReadLine()?.ToLower();
                if (answer != "si" && answer != "sí")
                {
                    Console.WriteLine("Gracias por jugar. ¡Hasta luego!");
                    break;
                }
            }
        }
    }
}
