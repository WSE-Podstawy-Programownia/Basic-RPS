using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.WriteLine("Wpisz: 'papier', 'kamie�' lub 'no�yce', a nast�pnie wci�nij ENTER");
            string userChoice = Console.ReadLine();

            Random rnd = new Random();
            int computerChoice = rnd.Next(1, 4);
            {
                if (computerChoice == 1)
                {
                    if (userChoice == "papier")
                    {
                        Console.WriteLine("Komputer wybra� papier");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == "kamie�")
                    {
                        Console.WriteLine("Komputer wybra� kamie�");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == "no�yce")
                    {
                        Console.WriteLine("Komputer wybra� no�yce");
                        Console.WriteLine("Remis!");
                    }
                    else
                    {
                        Console.WriteLine("Musisz wpisa� 'papier', 'kamie�' lub 'no�yce'!");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (userChoice == "papier")
                    {
                        Console.WriteLine("Komputer wybra� kamie�");
                        Console.WriteLine("Wygrana! Papier pokonuje kamie�");
                    }
                    else if (userChoice == "kamie�")
                    {
                        Console.WriteLine("Komputer wybra� no�yce");
                        Console.WriteLine("Wygrana! Kamie� pokonuje no�yce");
                    }
                    else if (userChoice == "no�yce")
                    {
                        Console.WriteLine("Komputer wybra� papier");
                        Console.WriteLine("Wygrana! No�yce pokonuj� papier");
                    }
                    else
                    {
                        Console.WriteLine("Musisz wpisa� 'papier', 'kamie�' lub 'no�yce'!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "papier")
                    {
                        Console.WriteLine("Komputer wybra� no�yce");
                        Console.WriteLine("Przegrana! No�yce pokonuj� papier");
                    }
                    else if (userChoice == "kamie�")
                    {
                        Console.WriteLine("Komputer wybra� papier");
                        Console.WriteLine("Przegrana! Papier pokonuje kamie�");
                    }
                    else if (userChoice == "no�yce")
                    {
                        Console.WriteLine("Komputer wybra� kamie�");
                        Console.WriteLine("Przegrana! Kamie� pokonuje no�yce");
                    }
                    else
                    {
                        Console.WriteLine("Musisz wpisa� 'papier', 'kamie�' lub 'no�yce'!");
                    }
                }
                Console.WriteLine("Chcesz zagra� jeszcze raz? t/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 't'; //continue only if y was pressed
            }
        }
    }
}