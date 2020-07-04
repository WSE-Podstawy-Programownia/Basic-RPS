using System;
using System.Collections.Generic;
using static System.Console;

class Player
{
    virtual public void GetInput(Dictionary<string, string> inputTable)
    {
        string rawInput;
        WriteLine("{0}, Choose:", PlayerName);
        foreach (KeyValuePair<string, string> entry in inputTable)
        {
            WriteLine("[{0}] {1}", entry.Key, entry.Value);
        }
        rawInput = ReadLine();
        while (!inputTable.TryGetValue(rawInput, out var lastInput))
        {
            LastInput = lastInput;

            WriteLine("Wrong input. Please enter correct one.");
            rawInput = ReadLine();
        }

    }
    public string PlayerName { get; protected set; }

    public string LastInput { get; set; }

    public Player(string playerName)
    {
        PlayerName = playerName;
    }

    public void SetPlayerName()
    {
        do
        {
            Clear();
            Write("Please enter player name: ");
            PlayerName = ReadLine();
        }
        while (PlayerName.Length == 0 || PlayerName.Length > 10);
    }

    public Player(bool invokeNameInput = true)
    {
        if (invokeNameInput)
        {
            SetPlayerName();
        }
    }
}
