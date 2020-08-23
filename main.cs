using System;



public class Program
{


  public static void Powitanie ()
  {
    Console.WriteLine("Cześć! Zagrajmy w RPS.");
    Console.WriteLine("Zasady są proste - Kamień bije Nożyce, Nożyce biją Papier, Papier bije Kamień. Wybierz figurę, która pokona figurę wybraną przez Twojego przeciwnika, żeby zyskać punkt.");
  }
  
  public static string GraczWybiera ()
  {
     string Gracz;
     string GraczSlowo;

      Console.WriteLine("Wybierz jedno: \n1->Kamień\n2->Papier\n3->Nożyce");
      Gracz = Console.ReadLine();
       while (Gracz != "1" && Gracz != "2" && Gracz != "3")
        {
            Console.WriteLine("Nieprawidłowy wybór. Wybierz cyfrę od 1 do 3");
            Gracz = Console.ReadLine();
        }
         if (Gracz == "1") { GraczSlowo = "Kamien"; }
        else if (Gracz == "2") { GraczSlowo = "Papier"; }
        else { GraczSlowo = "Nozyce"; }
        return Gracz;
        return GraczSlowo;
  }

  public static int PCWybiera ()
  {
    Random rnd = new Random();
    int PCyfra = rnd.Next(0, 3);
    return PCyfra;
  }

  public static int SprawdzenieZwyciezcy(string Gracz, string PCyfra)
  {
   if (Gracz == PCyfra)
   {
     Console.WriteLine ("Remis!");
     return 0;
   }
   else if ((Gracz == "1" && PCyfra == "3") ||
         (Gracz == "2" && PCyfra == "1") ||
         (Gracz == "3" && PCyfra == "2"))
         {
            Console.WriteLine ("Wygrałeś!");
            return 1;
         }
   else
   {
     Console.WriteLine ("Przegrałeś!");
     return 2;
   }
  }

static void MenuGlowne ()
{
  ConsoleKeyInfo inputKey;
do 
{
  Clear();
  WriteLine ("Kamień, Papier i Nożyce - Menu:\n\t[1] Zagraj\n\t[2] Zasady\n\t[ESC] Wyjście");
  inputKey = ReadKey(true);
  
  if (inputKey.Key == ConsoleKey.D1){
  WriteLine("Opcja pierwsza");
  }
  else if (inputKey.Key == ConsoleKey.D2){
  Powitanie();
  }
  else { continue; }
WriteLine ("(Wybierz jedną z opcji)");
ReadKey(true);
} while (inputKey.Key != ConsoleKey.Escape);
}

  
  public static void Main(string[] args) 
  {
    MenuGlowne();
  } 
