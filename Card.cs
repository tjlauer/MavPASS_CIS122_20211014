// Jeremy :), Kidus, and the rest of Mav Pass
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211014
{
	public abstract class Card
	{
		private string title = "n/a";
		private string flavorText = "n/a";

		// Gets and sets

		public string Title
		{
			get { return this.title; }
			set { this.title = value; }
		}

		public string FlavorText
		{
			get { return this.flavorText; }
			set { this.flavorText = value; }
		}

		public Card() : this("n/a", "n/a") { }
		
		public Card(string aTitle, string aFlavorText)
		{
			this.flavorText = aFlavorText;
			this.title = aTitle;

		}

		public override string ToString()
		{
			return this.Title;
		}
	}
}
