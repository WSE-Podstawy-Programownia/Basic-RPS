using System;
using static System.Console;
class Player
{
    public string PlayerName { get; set; }


    private readonly int maxNameLength = 20;
    public int Damage { get; set; }
    public int Health { get; set; }

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

    // public string playerName;
    public Player(string playerName)
    {
        this.PlayerName = playerName;
    }
    public Player()
    {
        SetPlayerName();
    }

}
