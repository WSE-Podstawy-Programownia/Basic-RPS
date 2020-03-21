using System;

//TODO
/*stworzyć klasę dla gracza, która przechowuje jego statystyki
poziom [1 - 3]
atak == poziom
exp
exp do następnego poziomu
imie
klase/profesje  [profesja : klasy player]
*/

/*
napisać metodę pobierającą wynik i wyświetlającą go graficznie
for [*] i [ ] - gramy do 10 pkt
*/

//stworzyć przed walką możliwość wyboru przeciwnika

/*umiejetnosci [inherited metody]
Paladyn - dodaje sobie 1/2/3 pkt
łotrzyk - zamienia pkt przeciwnika i swoje (raz na walkę)
mag - resetuje wszystkie pkt (raz na walkę)
*/

//po kazdej walce dodajemy expa graczowi

class MainClass {

  enum Symbols
      {
        Rock = 1,
        Paper,
        Scissors
      }

  public static void Main (string[] args) {
    


    RockPaperScissorsGame();

  }

  public static void RockPaperScissorsGame()
  {
    //variable declaration
    Random randomGenerator = new Random();
    string playerInput = "";
    Symbols playerSymbol;
    Symbols computerSymbol;
    int playerWins = 0;
    int computerWins = 0;

    //Welcome Message
    Console.WriteLine("Welcome to Rock Paper Scissors. MAN VS. MACHINE EDITION!\n");
    Console.WriteLine("Please play as long as you'd like. If you want to quit type 'exit'. \n"
    + "The score will be summed up and you will be able to view the final results.\n");

    //Game Loop
    while (true)
    {
      //Prompt the user for input and decide if it's correct
      Console.WriteLine("Please type:\n(1) Rock\n(2) Paper\n(3) Scissors\n[Type 'exit' to quit]");

      playerInput = Console.ReadLine();

      if(playerInput == "exit")
      {
        break;
      }
      else if (playerInput != "1" && playerInput != "2" &&  playerInput != "3")
      {
        Console.WriteLine("Your input does not match the instructions, please try again.");
        continue;
      }

      playerSymbol = (Symbols) Int32.Parse(playerInput);

      //Generate the computer symbol

      computerSymbol = (Symbols) randomGenerator.Next(1, 4);
      Console.WriteLine("Player: {0}\nComputer: {1}", playerSymbol, computerSymbol);

      //Determine who won
      //Player chose Rock
      if (playerSymbol == Symbols.Rock)
      {
        if (computerSymbol == Symbols.Rock)
        {
          Console.WriteLine("It's a TIE!");
        }
        else if (computerSymbol == Symbols.Paper)
        {
          computerWins++;
          Console.WriteLine("The computer WON!");
        } else
        {
          playerWins++;
          Console.WriteLine("The player WON!");
        }
      }

      //Player chose Paper
      else if (playerSymbol == Symbols.Paper)
      {
        if (computerSymbol == Symbols.Rock)
        {
          playerWins++;
          Console.WriteLine("The player WON!");
        }
        else if (computerSymbol == Symbols.Paper)
        {
          Console.WriteLine("It's a TIE!");
        }
        else
        {
          computerWins++;
          Console.WriteLine("The computer WON!");
        }
      }
      //Player chose Scissors
      else
      {
        if (computerSymbol == Symbols.Rock)
        {
          computerWins++;
          Console.WriteLine("The computer WON!");
        }
        else if (computerSymbol == Symbols.Paper)
        {
          playerWins++;
          Console.WriteLine("The player WON!");
        } else
        {
          Console.WriteLine("It's a TIE!");
        }
      }

      Console.WriteLine("Press any Key to continue");
      Console.ReadKey();
      Console.Clear();
    }

    //Display Score and QUIT
    Console.Clear();
    Console.WriteLine("The score is:");
    Console.WriteLine("Player: {0} || Computer: {1}", playerWins, computerWins);

    if (playerWins > computerWins)
    {
      Console.WriteLine("The Player WON!");
    }
    else if (playerWins < computerWins)
    {
      Console.WriteLine("The Computer WON, Machines rule the world!");
    } 
    else
    {
      Console.WriteLine("It's a TIE :(");
    }

    Console.WriteLine("Quitting application...");
  }
}