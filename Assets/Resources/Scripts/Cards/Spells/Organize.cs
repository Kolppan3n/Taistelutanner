using UnityEngine;
using System.Collections;

public class Organize : Spell {


	public override void SetStats ()
	{
		ID = 401;
		Name = "Organize";
		Type = "Spell";
		Rarity = "Common";
		Cardtext = "Reorder 3";
		Cost = "W";
		SetImage("Organize");
	}



}
