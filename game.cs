using System;
using System.Collections.Generic;
using static System.Console;

abstract class Game
{
    protected abstract string DetermineWinner();
    public abstract string GameName { get; }
    public abstract string GameRules { get; }
    protected abstract Dictionary<string, string> InputTable { get; }

    protected Player playerOne, playerTwo;    
    public GamesRecord gamesRecord;

    protected virtual string ChoosePhrase => "Choose:";

    protected Game()
    {
        gamesRecord = new GamesRecord();
    }
    
    public void InitializePlayers(bool singleplayer = false)
    {
        playerOne = new Player();
        if (singleplayer) playerTwo = new AIPlayer();
        else playerTwo = new Player();

        playerOne.ChoosePhrase = ChoosePhrase;
        playerTwo.ChoosePhrase = ChoosePhrase;
    }    

    public void Play()
    {
        Clear();
        playerOne.GetInput(InputTable);

        Clear();
        playerTwo.GetInput(InputTable);

        Clear();

        WriteLine($"{playerOne.PlayerName} chose: {playerOne.LastInput}, {playerTwo.PlayerName} chose {playerTwo.LastInput}");
        string gameResult = DetermineWinner();
        gamesRecord.AddRecord(playerOne.LastInput, playerTwo.LastInput, gameResult);        

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Play();
        }
    }
}