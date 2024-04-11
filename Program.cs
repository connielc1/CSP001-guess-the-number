namespace CSP001_guess_the_number
//CSP001_guess_the_number
{
    class MainClass
    {
        public static void Main (string[] args)
        {
 
            Random r= new Random ();
 
            //Genera un numero entre 10 y 100 (101 no se incluye)
            Console.WriteLine(r.Next (10,101));
 
            Console.ReadLine ();
        }
 
    }
}