using System;
using System.Collections.Generic;
using static System.Console;

class Player
{
    public string lastInput;
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
    public string playerName;

    public Player(string playerName)
    {
        this.playerName = playerName;
    }

    public void SetPlayerName()
    {
        do
        {
            Clear();
            Write("Please enter player name: ");
            playerName = ReadLine();
        }
        while (playerName.Length == 0 || playerName.Length > 10);
    }

    public Player()
    {
        SetPlayerName();
    }
}
