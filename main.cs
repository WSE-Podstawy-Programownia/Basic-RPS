using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chcesz zagraæ z komputerem? t/n");
        bool playWithComputer = Console.ReadKey().KeyChar == 't';

        bool keepPlaying = true;
        while (keepPlaying)
        {
            int player1 = GetChoice();

            int player2;

            if (playWithComputer)
            {
                Random rnd = new Random();
                player2 = rnd.Next(1, 4);
            }
            else 
            {
                player2 = GetChoice();
            }

            if (player2 == 1)
            {
                if (player1 == 1)
                {
                    Console.WriteLine("Komputer wybra³ papier");
                    Console.WriteLine("Remis!");
                }
                else if (player1 == 2)
                {
                    Console.WriteLine("Komputer wybra³ kamieñ");
                    Console.WriteLine("Remis!");
                }
                else if (player1 == 3)
                {
                    Console.WriteLine("Komputer wybra³ no¿yce");
                    Console.WriteLine("Remis!");
                }
            }
            else if (player2 == 2)
            {
                if (player1 == 1)
                {
                    Console.WriteLine("Komputer wybra³ kamieñ");
                    Console.WriteLine("Wygrana! Papier pokonuje kamieñ");
                }
                else if (player1 == 2)
                {
                    Console.WriteLine("Komputer wybra³ no¿yce");
                    Console.WriteLine("Wygrana! Kamieñ pokonuje no¿yce");
                }
                else if (player1 == 3)
                {
                    Console.WriteLine("Komputer wybra³ papier");
                    Console.WriteLine("Wygrana! No¿yce pokonuj¹ papier");
                }
            }
            else if (player2 == 3)
            {
                if (player1 == 1)
                {
                    Console.WriteLine("Komputer wybra³ no¿yce");
                    Console.WriteLine("Przegrana! No¿yce pokonuj¹ papier");
                }
                else if (player1 == 2)
                {
                    Console.WriteLine("Komputer wybra³ papier");
                    Console.WriteLine("Przegrana! Papier pokonuje kamieñ");
                }
                else if (player1 == 3)
                {
                    Console.WriteLine("Komputer wybra³ kamieñ");
                    Console.WriteLine("Przegrana! Kamieñ pokonuje no¿yce");
                }
            }
            Console.WriteLine("Chcesz zagraæ jeszcze raz? t/n");
            ConsoleKeyInfo cki = Console.ReadKey(); //czekaj a¿ gracz wciœnie przycisk
            keepPlaying = cki.KeyChar == 't'; //graj dalej tylko wtedy, gdy wciœniêto t
            Console.Clear();
        }
    }

    private static int GetChoice()
    {
        while (true)
        {
            Console.WriteLine("Wybierz: 1 - papier, 2 - kamieñ lub 3 - no¿yce, a nastêpnie wciœnij ENTER");
            if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice < 1 || choice > 3)
            {
                Console.WriteLine("Musisz wybraæ 1 - papier, 2 - kamieñ lub 3 - no¿yce!");
                continue;
            }
            return choice;
        }
    }
}