using System;
using System.Collections.Generic;
using static System.Console;
public class Player
{
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

    private readonly int maxNameLength = 20;

    public Player(string playerName)
    {
        this.PlayerName = playerName;
    }
    public Player(bool invokeNameInput = true)
    {
        if (invokeNameInput)
        {
            SetPlayerName();
        }
    }


    public virtual void GetInput(Dictionary<int, string> inputTable)
    {
        int playerChoice;
        bool playerParseSuccess;

        do
        {
            WriteLine($"{PlayerName}, choose:");
            foreach (var entry in inputTable)
            {
                WriteLine($"[{entry.Key}] {entry.Value}");
            }

            playerParseSuccess = Int32.TryParse(Console.ReadLine(), out playerChoice);
        } while (!inputTable.TryGetValue(playerChoice, out lastInput));

    }


    public int Damage { get; set; }

    public int Health { get; set; }
    public string LastInput { get => lastInput; set => lastInput = value; }

    public void SetPlayerDamage()
    {
        while (true)
        {
            Console.WriteLine($"{PlayerName}, please choose your damage.");
            try
            {
                string playerInput = Console.ReadLine();
                Damage = Int32.Parse(playerInput);
                if (Damage < 1)
                {
                    WriteLine("Damage must be positive.");
                    continue;
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                continue;
            }
            break;
        }
    }

    public void SetPlayerHealth()
    {
        while (true)
        {
            Console.WriteLine($"{PlayerName}, please choose your health.");
            try
            {
                string playerInput = Console.ReadLine();
                Health = Int32.Parse(playerInput);
                if (Health < 1)
                {
                    WriteLine("Health must be positive.");
                    continue;
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                continue;
            }
            break;
        }
    }
    public void SetPlayerName()
    {
        Console.Write("Enter your name:");
        PlayerName = Console.ReadLine();
        if (PlayerName.Length > maxNameLength || PlayerName.Length == 0)
        {
            throw new Exception("Invalid player name.");
        }
    }

}
