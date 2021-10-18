// HaesuJang  and the rest of Mav Pass
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211014
{
	public class Pokemon: Card
	{
		private int hp = 0;
		private int damage = 0;

		//gets and set
		public int Hp { get { return this.hp; } set { this.hp = value; } }
		public int Damage { get { return this.damage; } set { this.damage= value; } }


		// Constructor
		public Pokemon(): this("n/a", "n/a", 0, 0) { }

		public Pokemon(string aTitle, string aFlavorText, int aHP, int aDamage): base(aTitle, aFlavorText)
		{
			this.Hp = aHP;
			this.Damage = aDamage;
		}

	}
}
