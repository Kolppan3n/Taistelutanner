using UnityEngine;
using System.Collections;

public class Windy_Sniper : Creature {


	public override void SetStats ()
	{
		ID = 402;
		Name = "Windy_Sniper";
		Type = "Creature";
		Rarity = "Common";
		Cardtext = "Ranged";
		Cost = "WWW";
		Attack = 2;
		Health = 1;
		SetImage("Windy_Sniper");
	}



}
