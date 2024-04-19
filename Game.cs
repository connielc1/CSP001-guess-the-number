using System;

namespace CSP001_guess_the_number
{
    class Game
    {
        private readonly Player player;
        private readonly int secretNumber;
        private int failedAttempts;

        public Game(string playerName)
        {
            if (string.IsNullOrEmpty(playerName))
            {
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(playerName));
            }

            player = new Player(playerName);
            secretNumber = RandomNumberGenerator();
            failedAttempts = 0;
        }

        public void Start()
        {
            Console.WriteLine("Bienvenidx al juego de adivinar el número :)");
            Console.WriteLine($"Hola, {player.Name}. Adivina el número secreto entre 1 y 100:");

            while (true)
            {
                string input = Console.ReadLine() ?? "";
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Por favor, ingresa un número válido:");
                    continue;
                }

                if (CheckGuess(guess, secretNumber))
                {
                    Console.WriteLine("¡Felicidades! ¡Has adivinado el número secreto!");
                    break;
                }
                else
                {
                    failedAttempts++;
                    if (failedAttempts >= 5)
                    {
                        Console.WriteLine("¿Quieres intentarlo de nuevo? (Sí/No)");
                        string answer = (Console.ReadLine() ?? "").ToLower();
                        if (answer != "si" && answer != "sí")
                        {
                            Console.WriteLine("Gracias por jugar. ¡Hasta luego!");
                            break;
                        }
                        else
                        {
                            failedAttempts = 0;
                            Console.WriteLine($"Ok, {player.Name}. Adivina el número secreto entre 1 y 100:");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El número secreto es {(guess < secretNumber ? "mayor" : "menor")}. Intenta de nuevo:");
                    }
                }
            }
        }

        private int RandomNumberGenerator()
        {
            return new Random().Next(1, 101);
        }

        private bool CheckGuess(int guess, int targetNumber)
        {
            player.LastGuess = guess;

            if (player.LastGuess == targetNumber)
            {
                return true;
            }

            return false;
        }
    }
}