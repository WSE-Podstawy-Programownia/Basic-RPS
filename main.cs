using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {

    string[,] wyniki = new string[100,3];

    int numergry = 0;
   
    while (true){     
    string wiadomoscPowitalna = "\nWitaj!";
    WriteLine(wiadomoscPowitalna);
    WriteLine("\nGraczu pierwszy, wybierz jedną z opcji:\n\n1 - Kamień\n2 - Papier\n3 - Nożyce");
    string InputPlayerOne;
    InputPlayerOne = ReadLine();
        
      if (InputPlayerOne =="1"){
        wyniki [numergry, 0] = "Kamień";

      WriteLine ("Gracz pierwszy wybrał kamień");
    }
    else if (InputPlayerOne == "2"){
      wyniki [numergry, 0] = "Papier";
      WriteLine ("Gracz pierwszy wybrał papier");
    }
    else if (InputPlayerOne =="3"){
      wyniki [numergry, 0] = "Nożyce";
      WriteLine ("Gracz pierwszy wybrał nożyce");
    }
    else {
      wyniki [numergry, 0] = "Coś innego";
      WriteLine ("Gracz wybrał coś innego");
    }

 WriteLine("\nGraczu drugi, wybierz jedną z opcji:\n\n1 - Kamień\n2 - Papier\n3 - Nożyce");
    string InputPlayerTwo;
    InputPlayerTwo = ReadLine();

      if (InputPlayerTwo =="1"){
        wyniki [numergry, 1] = "Kamień";
      WriteLine ("Gracz drugi wybrał kamień");
    }
    else if (InputPlayerTwo =="2"){
      wyniki [numergry, 1] = "Papier";
      WriteLine ("Gracz drugi wybrał papier");
    }
    else if (InputPlayerTwo =="3"){
      wyniki [numergry, 1] = "Nożyce";
      WriteLine ("Gracz drugi wybrał nożyce");
    }
    else {
      wyniki [numergry, 1] = "Coś innego";
      WriteLine ("Gracz wybrał coś innego");
    }

    if (InputPlayerOne =="1" && InputPlayerTwo =="3" || InputPlayerOne =="2" && InputPlayerTwo =="1" || InputPlayerOne =="3" && InputPlayerTwo =="2"){
  WriteLine ("Gracz pierwszy wygrał!");
  wyniki [numergry, 2] = "Wygrał gracz pierwszy";
  }
  else if (InputPlayerOne =="3" && InputPlayerTwo =="1" || InputPlayerOne =="1" && InputPlayerTwo =="2" || InputPlayerOne =="2" && InputPlayerTwo =="3"){
  WriteLine ("Gracz drugi wygrał!");
   wyniki [numergry, 2] = "Wygrał gracz drugi";
  } 
else {
  WriteLine ("Remis!");
  wyniki [numergry, 2] = "Remis";
}
WriteLine ("Czy chcesz wyjść? [y]");
string PlayerResponse;
    PlayerResponse = ReadLine();
    Clear();

    if (PlayerResponse == "y"){
      Console.WriteLine ("Uzyskane wyniki to:");
        for (int p = 0; p < numergry+1; p++){
        Console.WriteLine ("Gra #{0}: {1} - {2}. Wynik: {3}",
       p+1, wyniki[p,0], wyniki[p,1], wyniki[p,2]);
}
Console.ReadLine ();{break;}
    }
  
    else {
    numergry = numergry+1;
    }
    

}
}
}

   