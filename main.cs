using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.WriteLine("Wybierz: 1 - papier, 2 - kamieñ lub 3 - no¿yce, a nastêpnie wciœnij ENTER");
            if (Int32.TryParse(Console.ReadLine(), out int userChoice) == false || userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("Musisz wybraæ 1 - papier, 2 - kamieñ lub 3 - no¿yce!");
                continue;
            }

            Random rnd = new Random();
            int computerChoice = rnd.Next(1, 4);
            {
                if (computerChoice == 1)
                {
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Komputer wybra³ papier");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Komputer wybra³ kamieñ");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Komputer wybra³ no¿yce");
                        Console.WriteLine("Remis!");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Komputer wybra³ kamieñ");
                        Console.WriteLine("Wygrana! Papier pokonuje kamieñ");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Komputer wybra³ no¿yce");
                        Console.WriteLine("Wygrana! Kamieñ pokonuje no¿yce");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Komputer wybra³ papier");
                        Console.WriteLine("Wygrana! No¿yce pokonuj¹ papier");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Komputer wybra³ no¿yce");
                        Console.WriteLine("Przegrana! No¿yce pokonuj¹ papier");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Komputer wybra³ papier");
                        Console.WriteLine("Przegrana! Papier pokonuje kamieñ");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Komputer wybra³ kamieñ");
                        Console.WriteLine("Przegrana! Kamieñ pokonuje no¿yce");
                    }
                }
                Console.WriteLine("Chcesz zagraæ jeszcze raz? t/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 't'; //continue only if y was pressed
                Console.Clear();
            }
        }
    }
}