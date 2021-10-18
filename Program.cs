using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211014
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Deck theBestDeck = new Deck();
			theBestDeck.AddCard(new Pokemon());

			
			Console.WriteLine(theBestDeck.Draw().ToString());
			Console.WriteLine(theBestDeck.Draw().ToString());
			Console.WriteLine(theBestDeck.ListOfCards.Count);
			Console.ReadLine();
		}
	}
}
