using UnityEngine;
using System.Collections;

public class Järjestely : Spell {


	public override void SetStats ()
	{
		ID = 401;
		Name = "Järjestely";
		Image = "Järjestely";
		Type = "Skenaario";
		Rarity = "Copper";
		Cardtext = "Järjestely 3 (Järjestelläksesi 3, katso pakkasin 3 päälimmäistä korttia ja laita niistä haluamasi määrä pakan pohjalle.)";
		Cost = "K";
		Faction = "Knowledge";
	}



}
