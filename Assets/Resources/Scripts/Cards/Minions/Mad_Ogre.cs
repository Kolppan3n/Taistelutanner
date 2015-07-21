using UnityEngine;
using System.Collections;

public class Mad_Ogre : Creature {


	public override void SetStats ()
	{
		ID = 502;
		Name = "Mad_Ogre";
		Type = "Creature";
		Rarity = "Common";
		Cardtext = "Trample, Charge";
		Cost = "PPPCCC";
		Attack = 5;
		Health = 4;
		SetImage("Mad_Ogre");
	}



}
