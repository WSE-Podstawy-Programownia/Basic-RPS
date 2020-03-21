using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    while (true){     
    string wiadomoscPowitalna = "\nWitaj!";
    WriteLine(wiadomoscPowitalna);
    WriteLine("\nGraczu pierwszy, wybierz jedną z opcji:\n\n1 - Kamień\n2 - Papier\n3 - Nożyce");
    string InputPlayerOne;
    InputPlayerOne = ReadLine();

    if (InputPlayerOne =="1"){
      WriteLine ("Gracz pierwszy wybrał kamień");
    }
    else if (InputPlayerOne == "2"){
      WriteLine ("Gracz pierwszy wybrał papier");
    }
    else if (InputPlayerOne =="3"){
      WriteLine ("Gracz pierwszy wybrał nożyce");
    }
    else {
      WriteLine ("Gracz wybrał coś innego");
    }

 WriteLine("\nGraczu drugi, wybierz jedną z opcji:\n\n1 - Kamień\n2 - Papier\n3 - Nożyce");
    string InputPlayerTwo;
    InputPlayerTwo = ReadLine();

    if (InputPlayerTwo =="1"){
      WriteLine ("Gracz drugi wybrał kamień");
    }
    else if (InputPlayerTwo =="2"){
      WriteLine ("Gracz drugi wybrał papier");
    }
    else if (InputPlayerTwo =="3"){
      WriteLine ("Gracz drugi wybrał nożyce");
    }
    else {
      WriteLine ("Gracz wybrał coś innego");
    }
    if (InputPlayerOne =="1" && InputPlayerTwo =="3" || InputPlayerOne =="2" && InputPlayerTwo =="1" || InputPlayerOne =="3" && InputPlayerTwo =="2"){
  WriteLine ("Gracz pierwszy wygrał!");
  }
  else if (InputPlayerOne =="3" && InputPlayerTwo =="1" || InputPlayerOne =="1" && InputPlayerTwo =="2" || InputPlayerOne =="2" && InputPlayerTwo =="3"){
  WriteLine ("Gracz drugi wygrał!");
  } 
else {
  WriteLine ("Remis!");
}
WriteLine ("Czy chcesz wyjść?");
string PlayerResponse;
    PlayerResponse = ReadLine();
    Clear();
    if (PlayerResponse == "y"){break;}
    ;
}
}
}

   