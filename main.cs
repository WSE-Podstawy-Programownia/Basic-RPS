using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.WriteLine("Wybierz: 1 - papier, 2 - kamie� lub 3 - no�yce, a nast�pnie wci�nij ENTER");
            if (Int32.TryParse(Console.ReadLine(), out int userChoice) == false || userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("Musisz wybra� 1 - papier, 2 - kamie� lub 3 - no�yce!");
                continue;
            }

            Random rnd = new Random();
            int computerChoice = rnd.Next(1, 4);
            {
                if (computerChoice == 1)
                {
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Komputer wybra� papier");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Komputer wybra� kamie�");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Komputer wybra� no�yce");
                        Console.WriteLine("Remis!");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Komputer wybra� kamie�");
                        Console.WriteLine("Wygrana! Papier pokonuje kamie�");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Komputer wybra� no�yce");
                        Console.WriteLine("Wygrana! Kamie� pokonuje no�yce");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Komputer wybra� papier");
                        Console.WriteLine("Wygrana! No�yce pokonuj� papier");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Komputer wybra� no�yce");
                        Console.WriteLine("Przegrana! No�yce pokonuj� papier");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Komputer wybra� papier");
                        Console.WriteLine("Przegrana! Papier pokonuje kamie�");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Komputer wybra� kamie�");
                        Console.WriteLine("Przegrana! Kamie� pokonuje no�yce");
                    }
                }
                Console.WriteLine("Chcesz zagra� jeszcze raz? t/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 't'; //continue only if y was pressed
                Console.Clear();
            }
        }
    }
}