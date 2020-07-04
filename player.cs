using System;
using System.Collections.Generic;
using static System.Console;

class Player
{
    private const int maxPlayerNameLength = 20;
    protected string playerName;
    private string lastInput;

    public string PlayerName
    {
        get
        {
            return playerName;
        }
        set
        {
            playerName = value;
        }
    }

    public string LastInput { get => lastInput; set => lastInput = value; }

    public Player(bool invokeNameInput = true)
    {
        if (invokeNameInput)
        {
            SetPlayerName();
        }
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
            PlayerName = newPlayerName;
        }
    }

    virtual public void GetInput(Dictionary<string, string> inputTable)
    {
        string rawInput;
        WriteLine($"{PlayerName}, Choose:");
        foreach (KeyValuePair<string, string> entry in inputTable)
        {
            WriteLine($"[{entry.Key}] {entry.Value}");
        }
        rawInput = ReadLine();
        while (!inputTable.TryGetValue(rawInput, out lastInput))
        {
            WriteLine("Wrong input. Please enter correct one.");
            rawInput = ReadLine();
        }
    }
}
