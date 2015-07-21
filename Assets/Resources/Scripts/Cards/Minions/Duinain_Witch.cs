using UnityEngine;
using System.Collections;

public class Duinain_Witch : Creature {


	public override void SetStats ()
	{
		ID = 302;
		Name = "Duinain_Witch";
		Type = "Creature";
		Rarity = "Common";
		Cardtext = "Ritual: Destroy target minion";
		Cost = "CCC";
		Attack = 2;
		Health = 1;
		SetImage("Duinain_Witch");
	}



}
