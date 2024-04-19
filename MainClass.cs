using System;

namespace CSP001_guess_the_number
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Antes de empezar, ingresa tu nombre:");
            string playerName = Console.ReadLine() ?? "";

            if (!string.IsNullOrEmpty(playerName))
            {
                Game game = new Game(playerName);
                game.Start();
            }
            else
            {
                Console.WriteLine("Nombre inválido. Reinicia el programa e intenta de nuevo.");
            }
        }
    }
}
