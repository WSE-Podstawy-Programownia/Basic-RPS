using System;
using static System.Console;

class Player
{
    private const int maxPlayerNameLength = 20;
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Strength { get; private set; }
    private bool isAi;

    public static Player CreateHumanPlayer(int health, int strength)
    {
        var player = new Player();
        player.SetName();
        player.isAi = false;
        player.Health = health;
        player.Strength = strength;
        return player;
    }

    public static Player CreateAiPlayer(int health, int strength)
    {
        var player = new Player();
        player.Name = "Computer";
        player.isAi = true;
        player.Health = health;
        player.Strength = strength;
        return player;
    }
    
    private Player()
    {        
    }
    
    private void SetName()
    {
        Write("Please enter player name: ");
        var newPlayerName = ReadLine();
        if (String.IsNullOrWhiteSpace(newPlayerName) || newPlayerName.Length > maxPlayerNameLength)
        {
            WriteLine($"Player name cannot be empty or have more than {maxPlayerNameLength} characters.");
            SetName();
        }
        else
        {
            Name = newPlayerName;
        }
    }

    public string GetPlayerInput()
    { 
        if (isAi)
        {
            return GetAiInput();
        }
        else
        {
            return GetHumanPlayerInput();
        }
    }

    private string GetHumanPlayerInput()
    {
        string rawInput;        
        WriteLine($"{Name}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
        while (rawInput != "1" && rawInput != "2" && rawInput != "3")
        {
            WriteLine($"Wrong input. Please enter correct one.\n{Name}, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = ReadLine();
        }
        return ConvertChoiceIntToChoiceString(Int32.Parse(rawInput));
    }

    private string GetAiInput()
    {
        return ConvertChoiceIntToChoiceString(new Random().Next(1,4));
    }

    private string ConvertChoiceIntToChoiceString(int choice)
    {
        if (choice == 1) { return "Rock"; }
        else if (choice == 2) { return "Paper"; }
        else { return "Scissors"; }        
    }

    public int GetHitStrength()
    {
        return new Random().Next(1, Strength + 1);
    }

    public void TakeHit(int hitStrength)
    {
        Health -= hitStrength;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }
}
