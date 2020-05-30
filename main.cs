using System;
using static System.Console;


class MainClass {
  
  enum Choices {
    Kamień,
    Papier,
    Nożyce
  }
  
  public static void Main (string[] args) {
    int gamesRecordSize = 10;
   
int gamesRecordCurrentSize = 0;
string[,] gamesRecord = new string[10,3];
int gamesRecordCurrentIndex = 0;
do {

     WriteLine ("Witaj w grze RPS:\n\nWciśnij dowolny przycisk");
    Console.ReadKey();
System.Console.Clear();
  
  
  WriteLine ("[Gracz 1] proszę podać swój typ:\n(1) kamień\n(2) papier\n(3) nożyce");
  
  string WybórPierwszegoGraczaString = ReadLine();
  gamesRecord[gamesRecordCurrentIndex, 0] = WybórPierwszegoGraczaString;

  Choices WybórPierwszegoGracza;
  if (WybórPierwszegoGraczaString == "1"){
      WybórPierwszegoGracza = Choices.Kamień;
  }
  else if (WybórPierwszegoGraczaString == "2"){
      WybórPierwszegoGracza = Choices.Papier;
  }
  else {
      WybórPierwszegoGracza = Choices.Nożyce;
  }

  
  System.Console.Clear();
  WriteLine ("Wybrałeś: " + WybórPierwszegoGracza + "\nWciśniej dowolny przycisk, aby kontynuować");
  
   Console.ReadKey();
   System.Console.Clear();

  WriteLine ("[Gracz2] proszę podać swój typ:\n(1) kamień\n(2) papier\n(3) nożyce");
  string WybórDrugiegoGraczaString = ReadLine();
  gamesRecord[gamesRecordCurrentIndex, 0] = WybórDrugiegoGraczaString;

  Choices WybórDrugiegoGracza;
  if (WybórDrugiegoGraczaString == "1"){
    WybórDrugiegoGracza = Choices.Kamień;
  }
  else if (WybórDrugiegoGraczaString == "2"){
    WybórDrugiegoGracza = Choices.Papier;
  }
  else {
    WybórDrugiegoGracza = Choices.Nożyce;
  }
  System.Console.Clear();
  WriteLine ("Wybrałeś: " + WybórDrugiegoGracza + "\nWciśniej dowolny przycisk, aby kontynuować");
  
   Console.ReadKey();
   System.Console.Clear();
  
  if (WybórPierwszegoGraczaString == WybórDrugiegoGraczaString){
    WriteLine ("Remis! Wybrano: " + WybórPierwszegoGracza + " vs " + WybórDrugiegoGracza);
   
   gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
 }

   else if ((WybórPierwszegoGracza == Choices.Kamień && WybórDrugiegoGracza == Choices.Nożyce)
            ||
            (WybórPierwszegoGracza == Choices.Nożyce && WybórDrugiegoGracza == Choices.Papier)
            ||
            (WybórPierwszegoGracza == Choices.Papier && WybórDrugiegoGracza == Choices.Kamień)
    ){
      Console.WriteLine ("Pierwszy gracz wygrał! Wybrano: " + WybórPierwszegoGracza + " vs " + WybórDrugiegoGracza);
    gamesRecord[gamesRecordCurrentIndex, 2] = "Pierwszy";
}
    else{
      Console.WriteLine ("Drugi gracz wygrał! Wybrano: " + WybórPierwszegoGracza + " vs " + WybórDrugiegoGracza);
    gamesRecord[gamesRecordCurrentIndex, 2] = "Drugi";}
 
 Console.ReadKey();
   System.Console.Clear();   

gamesRecordCurrentIndex += 1;




Console.WriteLine ("Uzyskane wyniki to:");
for (int i = 0; i < gamesRecordCurrentIndex; i++){
Console.WriteLine ("Gra #{0}: {1} - {2}, wygrał gracz {3}",
i+1, gamesRecord[i,0], gamesRecord[i,1], gamesRecord[i,2]);
}

Console.ReadKey();
System.Console.Clear(); 

gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) %
gamesRecordSize;
if (gamesRecordCurrentSize < gamesRecordSize){
gamesRecordCurrentSize++;
}

Console.WriteLine ("Czy chcesz zakończyć rozgrywkę? \nJeślij tak naciśnij (t) \n\nJeżeli chcesz grać dalej naciśnij (Enter)");  

} while (Console.ReadLine() != "t");


  }
}