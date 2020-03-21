using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chcesz zagra� z komputerem? t/n");
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
                    Console.WriteLine("Komputer wybra� papier");
                    Console.WriteLine("Remis!");
                }
                else if (player1 == 2)
                {
                    Console.WriteLine("Komputer wybra� kamie�");
                    Console.WriteLine("Remis!");
                }
                else if (player1 == 3)
                {
                    Console.WriteLine("Komputer wybra� no�yce");
                    Console.WriteLine("Remis!");
                }
            }
            else if (player2 == 2)
            {
                if (player1 == 1)
                {
                    Console.WriteLine("Komputer wybra� kamie�");
                    Console.WriteLine("Wygrana! Papier pokonuje kamie�");
                }
                else if (player1 == 2)
                {
                    Console.WriteLine("Komputer wybra� no�yce");
                    Console.WriteLine("Wygrana! Kamie� pokonuje no�yce");
                }
                else if (player1 == 3)
                {
                    Console.WriteLine("Komputer wybra� papier");
                    Console.WriteLine("Wygrana! No�yce pokonuj� papier");
                }
            }
            else if (player2 == 3)
            {
                if (player1 == 1)
                {
                    Console.WriteLine("Komputer wybra� no�yce");
                    Console.WriteLine("Przegrana! No�yce pokonuj� papier");
                }
                else if (player1 == 2)
                {
                    Console.WriteLine("Komputer wybra� papier");
                    Console.WriteLine("Przegrana! Papier pokonuje kamie�");
                }
                else if (player1 == 3)
                {
                    Console.WriteLine("Komputer wybra� kamie�");
                    Console.WriteLine("Przegrana! Kamie� pokonuje no�yce");
                }
            }
            Console.WriteLine("Chcesz zagra� jeszcze raz? t/n");
            ConsoleKeyInfo cki = Console.ReadKey(); //czekaj a� gracz wci�nie przycisk
            keepPlaying = cki.KeyChar == 't'; //graj dalej tylko wtedy, gdy wci�ni�to t
            Console.Clear();
        }
    }

    private static int GetChoice()
    {
        while (true)
        {
            Console.WriteLine("Wybierz: 1 - papier, 2 - kamie� lub 3 - no�yce, a nast�pnie wci�nij ENTER");
            if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice < 1 || choice > 3)
            {
                Console.WriteLine("Musisz wybra� 1 - papier, 2 - kamie� lub 3 - no�yce!");
                continue;
            }
            return choice;
        }
    }
}