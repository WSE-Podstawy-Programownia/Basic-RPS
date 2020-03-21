using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.WriteLine("Wpisz: 'papier', 'kamieñ' lub 'no¿yce', a nastêpnie wciœnij ENTER");
            string userChoice = Console.ReadLine();

            Random rnd = new Random();
            int computerChoice = rnd.Next(1, 4);
            {
                if (computerChoice == 1)
                {
                    if (userChoice == "papier")
                    {
                        Console.WriteLine("Komputer wybra³ papier");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == "kamieñ")
                    {
                        Console.WriteLine("Komputer wybra³ kamieñ");
                        Console.WriteLine("Remis!");
                    }
                    else if (userChoice == "no¿yce")
                    {
                        Console.WriteLine("Komputer wybra³ no¿yce");
                        Console.WriteLine("Remis!");
                    }
                    else
                    {
                        Console.WriteLine("Musisz wpisaæ 'papier', 'kamieñ' lub 'no¿yce'!");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (userChoice == "papier")
                    {
                        Console.WriteLine("Komputer wybra³ kamieñ");
                        Console.WriteLine("Wygrana! Papier pokonuje kamieñ");
                    }
                    else if (userChoice == "kamieñ")
                    {
                        Console.WriteLine("Komputer wybra³ no¿yce");
                        Console.WriteLine("Wygrana! Kamieñ pokonuje no¿yce");
                    }
                    else if (userChoice == "no¿yce")
                    {
                        Console.WriteLine("Komputer wybra³ papier");
                        Console.WriteLine("Wygrana! No¿yce pokonuj¹ papier");
                    }
                    else
                    {
                        Console.WriteLine("Musisz wpisaæ 'papier', 'kamieñ' lub 'no¿yce'!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "papier")
                    {
                        Console.WriteLine("Komputer wybra³ no¿yce");
                        Console.WriteLine("Przegrana! No¿yce pokonuj¹ papier");
                    }
                    else if (userChoice == "kamieñ")
                    {
                        Console.WriteLine("Komputer wybra³ papier");
                        Console.WriteLine("Przegrana! Papier pokonuje kamieñ");
                    }
                    else if (userChoice == "no¿yce")
                    {
                        Console.WriteLine("Komputer wybra³ kamieñ");
                        Console.WriteLine("Przegrana! Kamieñ pokonuje no¿yce");
                    }
                    else
                    {
                        Console.WriteLine("Musisz wpisaæ 'papier', 'kamieñ' lub 'no¿yce'!");
                    }
                }
                Console.WriteLine("Chcesz zagraæ jeszcze raz? t/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 't'; //continue only if y was pressed
            }
        }
    }
}