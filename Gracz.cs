using System;

class Gracz
{
  public string nazwaGracza;
  public Gracz (string nazwaGracza)
   {
   this.nazwaGracza = nazwaGracza;
   }

  public void WyborNazwyGracza ()
 {
  Console.WriteLine("Wprowadź swój nick: ");
  nazwaGracza = Console.ReadLine();
 }
  public Gracz ()
  {
    WyborNazwyGracza();
  }

}




