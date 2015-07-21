using UnityEngine;
using System.Collections;

public class Journeys_End : Spell {


	public override void SetStats ()
	{
		ID = 505;
		Name = "Journeys_End";
		Type = "Spell";
		Rarity = "Common";
		Cardtext = "Destroy all creatures";
		Cost = "WOPC";
		SetImage("Journeys_End");
	}



}
