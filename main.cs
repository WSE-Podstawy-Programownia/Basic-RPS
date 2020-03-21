using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
     WriteLine ("Witaj w grze RPS");

     
  
  System.Console.Clear();
  WriteLine ("[Gracz 1] proszę podać swój typ:\n(1) kamień\n(2) papier\n(3)");
  string wyborPierszegoGracza = ReadLine();
  
  System.Console.Clear();

  WriteLine ("[Gracz2] proszę podać swój typ:\n(1) kamień\n(2) papier\n(3)");
  string WybórDrugiegoGracza = ReadLine();
  if (wyborPierszegoGracza == WybórDrugiegoGracza){
    WriteLine ("Remis");
    }
  }

}