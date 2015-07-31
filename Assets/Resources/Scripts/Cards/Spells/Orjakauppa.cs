using UnityEngine;
using System.Collections;

public class Orjakauppa : Spell {


	public override void SetStats ()
	{
		ID = 503;
		Name = "Orjakauppa";
		Image = "Orjakauppa";
		Type = "Skenaario";
		Rarity = "Silver";
		Cardtext = "Rituaali: Nosta kortti (Kun tämä kortti pelataan uhraa kätyri)";
		Cost = "CK";
		Faction = "ChaosKnowledge";
	}



}
