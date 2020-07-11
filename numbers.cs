using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class Numbers : Game 
{
    public Numbers (){
        playerOne = new Player();
        playerTwo = new Player();
        gamesRecord = new GamesRecord();
        inputTable = new Dictionary<string, string>()
    {
      {"1", "100"},
      {"2", "101"},
    };
    }
    public string GetPlayerInput (Player player)
    {
        string rawInput;
        string properInput = "";

        WriteLine ("{0} Wybierz liczbę:\n[1] 100\n[2] 101", player);
        rawInput = ReadLine();

        while (rawInput != "1" && rawInput != "2")
        {
            WriteLine ("Zły wybór. Spróbuj ponownie.\nGraczu pierwszy, wybierz liczbę:\n[1] 100\n[2] 101");
            rawInput = ReadLine();
        }

        if (rawInput == "1") { properInput = "100"; }
        else if (rawInput == "2") { properInput = "101"; }
        return properInput;
    }

    string DetermineWinner (Player playerOne, Player playerTwo)
    {
        if (playerOne.LastInput == playerTwo.LastInput)
        {
            WriteLine ("Remis!");
            return "Draw";
        }
        else if ((playerOne.LastInput == "101" && playerTwo.LastInput == "100"))
        {
        Console.WriteLine ("{0} wygrał!", playerOne.PlayerName);
        return String.Format("{0} wygrał!", playerOne.PlayerName);
        }
        else
        {
        Console.WriteLine ("{0} wygrał!", playerTwo.PlayerName);
        return String.Format("{0} wygrał!", playerTwo.PlayerName);
        }
    }

    public override void PlayGame ()
    {
        Clear();

        playerOne.GetInput(inputTable);
    
        Clear ();
    
        playerTwo.GetInput(inputTable);
    
        Clear ();

        string gameResult = DetermineWinner(playerOne, playerTwo);
        gamesRecord.AddRecord(new RecordRPS(playerOne.LastInput, playerTwo.LastInput, gameResult));


        WriteLine("kolejna rozgrywka? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
        PlayGame();
        }
    }
}