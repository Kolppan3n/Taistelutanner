using UnityEngine;
using System.Collections;

public class Grow : Spell {


	public override void SetStats ()
	{
		ID = 501;
		Name = "Grow";
		Type = "Spell";
		Rarity = "Common";
		Cardtext = "Give a creature +2 Health and Overrun";
		Cost = "OP";
		SetImage("Grow");
	}



}
