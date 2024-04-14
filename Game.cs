using System;

namespace CSP001_guess_the_number
{
    class Game
    {
        private int secretNumber;
        private Player player;

        public Game(string playerName)
        {
            Random r = new Random();
            secretNumber = r.Next(1, 101);
            player = new Player(playerName);
        }

        public void Play()
        {
            Console.WriteLine("Bienvenidx al juego de adivinar el número :)");
            Console.WriteLine($"Hola, {player.Name}. Adivina el número secreto entre 1 y 100:");

            while (true)
            {
                player.MakeGuess();
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
            }
        }
    }
}
