using System;
using static System.Console;

class MainClass {
   public static void Main (string[] args) {
     while(true){
     WriteLine("[Player 1] please pick your type:\n(1) rock\n(2) paper\n(3) scissors");
     string ChoiceOfTheFirstPlayer = ReadLine();
     int ChoiceOfTheFirstPlayerInt;
     //probuje zmienic wartosc wczytana na int
     while(!Int32.TryParse(ChoiceOfTheFirstPlayer, out ChoiceOfTheFirstPlayerInt)
     ||int.Parse(ChoiceOfTheFirstPlayer) > 3
     ||int.Parse(ChoiceOfTheFirstPlayer) <= 0 ) {
       WriteLine("Give the right number");
       ChoiceOfTheFirstPlayer = ReadLine();
       }
       WriteLine("[Player 2] please pick your type:\n(1) rock\n(2) paper\n(3) scissors");
       string ChoiceOfTheSecondPlayer = ReadLine();
       if (ChoiceOfTheFirstPlayer == ChoiceOfTheSecondPlayer){
       WriteLine ("Draw");
       }
     WriteLine("Press any key to restart");
     ReadKey();
     Clear();
     }
   }
}