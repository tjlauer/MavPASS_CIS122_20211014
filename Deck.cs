//written by Mady Saf, Chase Devitt and the rest of Mav Pass

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211014
{


	public class Deck
	{
		private List<Card> listOfCards = new List<Card>();

		//gets and sets
		public List<Card> ListOfCards { get { return this.listOfCards; } set { this.listOfCards = value; } }

		//methods
		public void AddCard(Card c)
		{

			ListOfCards.Add(c);
		
		}
		public Card Draw()
		{
			int length = ListOfCards.Count - 1;
			if (length > 0)
			{
				Card CardToReturn = ListOfCards[length];
				ListOfCards.Remove(CardToReturn);
				return CardToReturn;// returns last card from list
			}
			return null;
		}


	}
}
