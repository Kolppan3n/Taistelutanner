using UnityEngine;
using System.Collections;

public class Raivopeikko : Creature {


	public override void SetStats ()
	{
		ID = 502;
		Name = "Raivopeikko";
		Image = "Raivopeikko";
		Type = "Kätyri";
		Rarity = "Silver";
		Cardtext = "Ryntäys(Voi hyökätä heti saavuttuaan taistelutantereelle), Rämistys(Tultuaan torjutuksi tämä olento tekee ylimääräisen vahingon vihollisen Sankariin)";
		Cost = "PPPCCC";
		Attack = 5;
		Health = 4;
		Faction = "PrimalChaos";
	}



}
