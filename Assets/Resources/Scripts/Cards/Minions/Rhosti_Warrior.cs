using UnityEngine;
using System.Collections;

public class Rhosti_Warrior : Creature {


	public override void SetStats ()
	{
		ID = 201;
		Name = "Rhosti_Warrior";
		Type = "Creature";
		Rarity = "Common";
		Cardtext = "";
		Cost = "P";
		Attack = 2;
		Health = 1;
		SetImage("Rhosti_Warrior");
	}



}
