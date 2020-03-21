using System;

class MainClass {
  public static void Main (string[] args) {
    string p1, p2, winner = "";
    Console.WriteLine("Witaj w grze RPS.\nWpisz papier, kamien lub nozyce.\n");

    Console.WriteLine("Gracz 1: ");    
    p1 = Console.ReadLine();
    while(p1 != "papier" && p1 != "nozyce" && p1 != "kamien") {
      Console.WriteLine("Błąd. Wpisz ponownie");
      p1 = Console.ReadLine();
    }
    Console.WriteLine("Gracz 2: ");    
    p2 = Console.ReadLine();
    while(p2 != "papier" && p2 != "nozyce" && p2 != "kamien") {
      Console.WriteLine("Błąd. Wpisz ponownie");
      p2 = Console.ReadLine();
    }

    if(p1 == "kamien" && p2 == "papier") {
      winner = "Gracz 1";
    } else if(p1 == "kamien" && p2 == "nozyce") {
      winner = "Gracz 2";
    } else if(p1 == "kamien" && p2 == "kamien") {
      winner = "Remis";
    } else if(p1 == "papier" && p2 == "papier") {
      winner = "Remis";
    } else if(p1 == "papier" && p2 == "kamien") {
      winner = "Gracz 1";
    } else if(p1 == "papier" && p2 == "nozyce") {
      winner = "Gracz 2";
    } else if(p1 == "nozyce" && p2 == "nozyce") {
      winner = "Remis";
    } else if(p1 == "nozyce" && p2 == "papier") {
      winner = "Gracz 1";
    } else if(p1 == "nozyce" && p2 == "kamien") {
      winner = "Gracz 2";
    } 
    Console.WriteLine("Wynik: {0}", winner);
    Console.ReadKey();
    Console.Clear();
  }
}