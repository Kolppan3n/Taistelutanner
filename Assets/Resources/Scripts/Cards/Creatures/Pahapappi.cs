using UnityEngine;
using System.Collections;

public class Pahapappi : Creature {


	public override void SetStats ()
	{
		ID = 302;
		Name = "Pahapappi";
		Image = "Pahapappi";
		Type = "Kätyri";
		Rarity = "Silver";
		Cardtext = "Riitti: Tuhoa kätyri (Kun tämä kortti pelataan uhraa kätyri)";
		Cost = "CCC";
		Attack = 2;
		Health = 1;
		Faction = "Chaos";
	}



}
