using UnityEngine;
using System.Collections;

public class Damatican_Battlepriest : Creature {


	public override void SetStats ()
	{
		ID = 102;
		Name = "Damatican_Battlepriest";
		Type = "Creature";
		Rarity = "Common";
		Cardtext = "Warcry: Heal 3";
		Cost = "OOO";
		Attack = 1;
		Health = 3;
		SetImage("Damatican_Battlepriest");
	}



}
