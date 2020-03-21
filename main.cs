using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Welcome! You're playing scissors,paper,rock game! Game rules: Scissors beat paper, paper beat rock, rock beat scissors. The game ends when you beat an opponent three times. Good luck! Ready! Steady! Go!");
    //Console.Clear();
    Console.WriteLine("[Gracz 1] Choose your type:\n(1) rock\n(2) paper\n(3) scissors");
    

    int FirstPlayerChoose;
    while()

    Console.WriteLine("[Gracz 2] Choose your type:\n(1) rock\n(2) paper\n(3) scissors");
    string SecondPlayerChoose = Console.ReadLine();
    if(FirstPlayerChoose == SecondPlayerChoose)
    {
      Console.WriteLine("Draw!");
    
    }
    if(FirstPlayerChoose=="1" &&  SecondPlayerChoose=="2"){
      Console.WriteLine("Second Player Won!");
    }
    
  }
}