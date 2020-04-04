using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Papier, kamieñ, no¿yce! Chcesz zagraæ z komputerem? t/n");
        bool playWithComputer = Console.ReadKey().KeyChar == 't';
        Console.WriteLine();

        int numberOfGames = 3;
        int gamesRecordCurrentIndex = 0;
        string[,] gamesRecord = new string[numberOfGames, 3];

        Console.WriteLine($"Startujemy! Zagramy do {numberOfGames}!");

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

            gamesRecord[gamesRecordCurrentIndex, 0] = ConvertChoiceToDescription(player1);
            gamesRecord[gamesRecordCurrentIndex, 1] = ConvertChoiceToDescription(player2);
            gamesRecord[gamesRecordCurrentIndex, 2] = ConvertWinnerToDescription(winner);
            gamesRecordCurrentIndex++;

            keepPlaying = gamesRecordCurrentIndex < numberOfGames;

            if (keepPlaying)
            {
                Console.WriteLine("Chcesz zagraæ jeszcze raz? t/n");
                keepPlaying = Console.ReadKey().KeyChar == 't';
            }
            else
            {
                Console.WriteLine("Rozegralismy wszystkie gry! Nacisnij dowolny klawisz...");
                Console.ReadKey();
            }
            Console.Clear();
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