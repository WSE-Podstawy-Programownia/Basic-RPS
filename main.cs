using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witaj w Papier, kamieñ, no¿yce! Chcesz zagraæ z komputerem? t/n");
        bool playWithComputer = GetYesOrNo();
        Console.WriteLine();

        int numberOfRecordedGames = 10;
        int gamesRecordCurrentIndex = 0;
        string[,] gamesRecord = new string[numberOfRecordedGames, 3];

        bool keepPlaying = true;
        while (keepPlaying)
        {
            Choice player1 = GetHumanChoice("Gracz 1");
            Choice player2;

            if (playWithComputer)
            {
                player2 = GetComputerChoice();
            }
            else 
            {
                player2 = GetHumanChoice("Gracz 2");
            }

            Console.WriteLine($"Gracz 1 wybra³: {ConvertChoiceToDescription(player1)}, gracz 2 wybra³: {ConvertChoiceToDescription(player2)}");
            var winner = GetWinner(player1, player2);
            Console.WriteLine(ConvertWinnerToDescription(winner));

            gamesRecord[gamesRecordCurrentIndex % numberOfRecordedGames, 0] = ConvertChoiceToDescription(player1);
            gamesRecord[gamesRecordCurrentIndex % numberOfRecordedGames, 1] = ConvertChoiceToDescription(player2);
            gamesRecord[gamesRecordCurrentIndex % numberOfRecordedGames, 2] = ConvertWinnerToDescription(winner);
            gamesRecordCurrentIndex++;
            
            Console.WriteLine("Chcesz zagraæ jeszcze raz? t/n");
            keepPlaying = GetYesOrNo();
            
            Console.Clear();
        }

        Console.WriteLine($"Liczba rozegranych gier: {gamesRecordCurrentIndex}");
        Console.WriteLine("Ostatnie wyniki:");
        for (int i = 0; i < numberOfRecordedGames; i++)
        {
            if (gamesRecordCurrentIndex - i > 0)
            {
                var gameIdx = (gamesRecordCurrentIndex - i - 1) % numberOfRecordedGames;
                Console.WriteLine($"[{i+1}] Gracz 1: {gamesRecord[gameIdx, 0]}, Gracz 2: {gamesRecord[gameIdx, 1]}, Wynik: {gamesRecord[gameIdx, 2]}");
            }
        }
        Console.WriteLine("Nacisnij dowolny klawisz...");
        Console.ReadKey();
    }

    static bool GetYesOrNo()
    {
        while (true)
        {
            var pressedKey = Console.ReadKey().KeyChar;
            if (pressedKey == 't') return true;
            if (pressedKey == 'n') return false;
            
            Console.WriteLine();
            Console.WriteLine("Wybierz t lub n");
        }
    }

    static Choice GetHumanChoice(string playerName)
    {
        while (true)
        {
            Console.WriteLine($"[{playerName}] Wybierz: 1 - papier, 2 - kamieñ lub 3 - no¿yce, a nastêpnie wciœnij ENTER");
            if (Int32.TryParse(Console.ReadLine(), out int choice) == false || choice < 1 || choice > 3)
            {
                Console.WriteLine($"[{playerName}] Musisz wybraæ 1 - papier, 2 - kamieñ lub 3 - no¿yce!");
                continue;
            }

            return ConvertIntToChoice(choice);
        }
    }

    static Choice GetComputerChoice()
    {
        return ConvertIntToChoice(new Random().Next(1, 4));
    }

    static Choice ConvertIntToChoice(int choice)
    {
        if (choice == 1) return Choice.Paper;
        if (choice == 2) return Choice.Rock;
        else return Choice.Scissors;
    }

    static string ConvertChoiceToDescription(Choice choice)
    {
        if (choice == Choice.Paper) return "papier";
        if (choice == Choice.Rock) return "kamieñ";
        else return "no¿yce";
    }

    static string ConvertWinnerToDescription(Winner winner)
    {
        if (winner == Winner.Player1) return "Gracz 1 wygrywa!";
        else if (winner == Winner.Player2) return "Gracz 2 wygrywa!";
        else return "Remis!";
    }

    static Winner GetWinner(Choice player1, Choice player2)
    {
        if (player1 == player2) return Winner.Tie;

        if (player1 == Choice.Rock && player2 == Choice.Scissors
            || player1 == Choice.Paper && player2 == Choice.Rock
            || player1 == Choice.Scissors && player2 == Choice.Paper)
            return Winner.Player1;

        return Winner.Player2;
    }

    enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    enum Winner
    {
        Player1,
        Player2,
        Tie
    }
}