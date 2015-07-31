using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Kerääntyminen : Spell {

	

	public override void SetStats ()
	{

		ID = 202;
		Name = "Kerääntyminen";
		Image = "Kerääntyminen";
		Type = "Skenaario";
		Rarity = "Silver";
		Cardtext = "Kerää 2 (Kerätäksesi 2, Lisää pakkasi 2 päällimmäistä korttia resursseihisi)";
		Cost = "GGGG";
		Faction = "Primal";
	}



}


