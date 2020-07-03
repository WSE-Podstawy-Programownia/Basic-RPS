using System;
using System.Collections.Generic;
using static System.Console;

public class Player
{
    public string playerName;

    private readonly int maxNameLength = 10;

    public string lastInput;

    public void SetPlayerName()
    {
        Write("Please enter player name: ");
        playerName = ReadLine();
        if (playerName.Length > maxNameLength || playerName.Length == 0)
        {
            throw new Exception("Invalid player name");
        }
    }

    public Player()
    {
        SetPlayerName();
    }

    public Player(string playerName)
    {
        this.playerName = playerName;
    }

    public virtual void GetInput(System.Collections.Generic.Dictionary<string, string> inputTable)
    {
        string rawInput;
        WriteLine("{0}, Choose:", playerName);
        foreach (KeyValuePair<string, string> entry in inputTable)
        {
            WriteLine("[{0}] {1}", entry.Key, entry.Value);
        }
        rawInput = ReadLine();
        while (!inputTable.TryGetValue(rawInput, out lastInput))
        {
            WriteLine("Wrong input. Please enter correct one.");
            rawInput = ReadLine();
        }
    }



}