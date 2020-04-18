using System;
using static System.Console;
class MainClass {
  public static void Main (string[] args) {
   int gamesRecordSize = 10;
   string[,] gamesRecord = new string[gamesRecordSize,3]; 
    int gamesRecordCurrentIndex = 0;
int gamesRecordCurrentSize = 0;

    do {
   WriteLine (" Witaj w kamiennej masakrze 9000! niech PlayerOne poda swoj typ:\n(1) kamien\n(2) papier\n(3) nozyce");
   string wyborpierwszegogracza = ReadLine();
   WriteLine("Doktor Biceps prosze podac swoj typ:\n(1) kamien\n(2) papier\n(3) nozyce");
string wybordrugiegogracza = ReadLine();
if (wyborpierwszegogracza == wybordrugiegogracza){
  WriteLine ("Remis");
  gamesRecord[gamesRecordCurrentIndex, 2] = "nie przelala sie krew";}
if (
  (wyborpierwszegogracza == "1" && wybordrugiegogracza == "2")||
  (wyborpierwszegogracza == "2" && wybordrugiegogracza == "3")||
  (wyborpierwszegogracza == "3" && wybordrugiegogracza == "1"))
{WriteLine ("wygral Doktor Biceps");
gamesRecord[gamesRecordCurrentIndex, 2] = "Doktor Biceps obronil swe wlosci";}
if ((wyborpierwszegogracza == "1" && wybordrugiegogracza == "3")||
    (wyborpierwszegogracza == "2" && wybordrugiegogracza == "1")||
    (wyborpierwszegogracza == "3" && wybordrugiegogracza == "2"))
{WriteLine ("wygral PlayerONE");gamesRecord[gamesRecordCurrentIndex, 2] = "playerone destroyed the game";}

ReadKey();
Clear();
gamesRecord[gamesRecordCurrentIndex, 0] = wyborpierwszegogracza;
gamesRecord[gamesRecordCurrentIndex, 1] = wybordrugiegogracza;
gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize; 
if (gamesRecordCurrentSize < gamesRecordSize){
  gamesRecordCurrentSize++;
}
 Console.WriteLine ("Doktor Biceps, czy chcesz się znowu upokorzyć? Wpisz PB żeby walczyć o czarne złoto");
} while (Console.ReadLine() == "PB");
int currentIndex;
if (gamesRecordCurrentSize < gamesRecordSize){
    currentIndex = 0;
  }
  else {
    currentIndex = gamesRecordCurrentIndex
  ;}
for (int i = 0; i < gamesRecordCurrentSize; i++){
  Console.WriteLine ("Gra #{0}: {1} - {2}, wygrał gracz {3}",
    i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
currentIndex = (currentIndex + 1) % gamesRecordSize; 
}
}}