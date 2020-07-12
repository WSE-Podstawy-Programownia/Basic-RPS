using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
					
public class Moneta
{
	public static void Rzut()
	{
		//próba rzutu monetą

		var rng = new Random();
		if (rng.NextDouble() < 0.5)
		{
			Console.WriteLine("Reszka");
		}
		else
		{
			Console.WriteLine("Orzeł");	
		}
	}
}