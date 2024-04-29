using System;

namespace CSP001_guess_the_number
{
    class Game
    {
        private readonly HumanPlayer _humanPlayer;
        private readonly AIPlayer _AIPlayer;
        private readonly int secretNumber;

        public Game(string playerName)
        {
            _humanPlayer = new HumanPlayer(playerName);
            _AIPlayer = new AIPlayer("Computer");
            secretNumber = RandomNumberGenerator();
        }

        public void Start()
        {
            Console.WriteLine("Bienvenidx al juego de adivinar el número :)");
            Console.WriteLine($"Hola, {_humanPlayer.Name}. Adivina el número secreto entre 1 y 100:");

            while (true)
            {
                int humanGuess = _humanPlayer.MakeGuess();
                _humanPlayer.AddGuess(humanGuess);

                if (CheckGuess(humanGuess, secretNumber))
                {
                    Console.WriteLine($"¡Felicidades, {_humanPlayer.Name}! ¡Has adivinado el número secreto!");
                    break;
                }
                else
                {
                    Console.WriteLine($"El número secreto es {(humanGuess < secretNumber ? "mayor" : "menor")}. Intenta de nuevo:");
                }

                int AIguess = _AIPlayer.MakeGuess();
                Console.WriteLine($"AI Player ha adivinado: {AIguess}");

                if (CheckGuess(AIguess, secretNumber))
                {
                    Console.WriteLine($"¡Lo siento, {_humanPlayer.Name}! ¡AI Player ha adivinado el número secreto!");
                    break;
                }
                else
                {
                    Console.WriteLine($"El número secreto es {(AIguess < secretNumber ? "mayor" : "menor")}. AI Player intentará de nuevo.");
                }
            }
        }

        private int RandomNumberGenerator()
        {
            return new Random().Next(1, 101);
        }

        private bool CheckGuess(int guess, int targetNumber)
        {
            return guess == targetNumber;
        }
    }
}
