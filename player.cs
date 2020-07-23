using System;
using System.Collections.Generic;
using static System.Console;

public class Player
{
    protected string playerName;

    private readonly int maxNameLength = 10;

    private string lastInput;

    public string PlayerName { get => playerName; set => playerName = value; }

    public string LastInput { get => lastInput; set => lastInput = value; }

    public void SetPlayerName()
    {
        Write("Please enter player name: ");
        PlayerName = ReadLine();
        if (PlayerName.Length > maxNameLength || PlayerName.Length == 0)
        {
            throw new Exception("Invalid player name");
        }
    }

    public Player(bool invokePlayerName = true)
    {
        if (invokePlayerName)
        {
            SetPlayerName();
        }
    }

    public Player(string playerName)
    {
        this.PlayerName = playerName;
    }

    public virtual void GetInput(System.Collections.Generic.Dictionary<string, string> inputTable)
    {
        string rawInput;
        WriteLine("{0}, Choose:", PlayerName);
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