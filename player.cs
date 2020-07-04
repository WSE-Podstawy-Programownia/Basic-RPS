using System;
using System.Collections.Generic;
using static System.Console;

class Player
{
    private const int maxPlayerNameLength = 20;
    public string playerName;
    public string lastInput;

    public Player(string playerName)
    {
        this.playerName = playerName;
    }

    public Player()
    {
        SetPlayerName();
    }

    public void SetPlayerName()
    {
        Write("Please enter player name: ");
        var newPlayerName = ReadLine();
        if (String.IsNullOrWhiteSpace(newPlayerName) || newPlayerName.Length > maxPlayerNameLength)
        {
            WriteLine($"Player name cannot be empty or have more than {maxPlayerNameLength} characters.");
            SetPlayerName();
        }
        else
        {
            playerName = newPlayerName;
        }
    }

    virtual public void GetInput(Dictionary<string, string> inputTable)
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
