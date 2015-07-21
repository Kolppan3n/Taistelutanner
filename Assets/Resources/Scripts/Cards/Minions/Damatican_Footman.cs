using UnityEngine;
using System.Collections;

public class Damatican_Footman : Creature {


	public override void SetStats ()
	{
		ID = 101;
		Name = "Damatican_Footman";
		Type = "Creature";
		Rarity = "Common";
		Cardtext = "";
		Cost = "O";
		Attack = 1;
		Health = 2;
		SetImage("Damatican_Battlepriest");
	}



}
