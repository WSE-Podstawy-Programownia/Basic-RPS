using System;..
using static System.Console;
class MainClass {
  public static void Main (string[] args) {
    while(true){
   WriteLine (" Witaj w kamiennej masakrze 9000! niech[Gracz pierwszy] poda swoj typ:\n(1) kamien\n(2) papier\n(3) nozyce");
   string wyborpierwszegogracza = ReadLine();
   WriteLine("[Gracz drugi] prosze podac swoj typ:\n(1) kamien\n(2) papier\n(3) nozyce");
string wybordrugiegogracza = ReadLine();
if (wyborpierwszegogracza == wybordrugiegogracza){WriteLine ("Remis");}
if (wyborpierwszegogracza == "1" && wybordrugiegogracza == "2")
{WriteLine ("wygral Gracz drugi");}
if (wyborpierwszegogracza == "1" && wybordrugiegogracza == "3")
{WriteLine ("wygral Gracz pierwszy");}
if (wyborpierwszegogracza == "2" && wybordrugiegogracza == "1")
{WriteLine ("wygral Gracz pierwszy");}
if (wyborpierwszegogracza == "2" && wybordrugiegogracza == "3")
{WriteLine ("wygral Gracz drugi");}
if (wyborpierwszegogracza == "3" && wybordrugiegogracza == "1")
{WriteLine ("wygral Gracz drugi");}
if (wyborpierwszegogracza == "3" && wybordrugiegogracza == "2")
{WriteLine ("wygral Gracz pierwszy");}
ReadKey();
Clear();
}}}