using System;
using static System.Console;

class Game
{
    Player playerOne, playerTwo;
    GamesRecord gamesRecord;

    public Game()
    {
        playerOne = new Player();
        playerTwo = new Player();
        gamesRecord = new GamesRecord();

    }
}