using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
		 * PELIN "ELEMENTIT"
		 * 
		 * ORDER
		 * CHAOS
		 * WISDOM
		 * PRIMAL
		 * 
		 */

public class Card : MonoBehaviour, System.IComparable<Card>{
	
	public int ID;
	public string Name;
	public string Type;
	public string Rarity;
	public string Cardtext;
	public string Cost;
	public string Faction;
	public string Image;
	public Card(){
		
	}
	virtual public void Start(){
		SetStats ();
	}

	virtual public void SetStats(){
	}

	/*void test(){
			string pattern = ".*WW.*RRR.*";
			Regex r = new Regex(pattern,RegexOptions.IgnoreCase);
			Match m = r.Match(Cost);
		}

		void getasd(string n){
			string tmp = ".*";
			for (int i = 0; i<n.Length; i++) {
				tmp += n[i]+".*";
			}
		}*/

	public int CompareTo (Card other)
	{

		if (this.ID < other.ID)
			return -1;
		if (ID == other.ID)
			return 0;
		if (ID > other.ID)
			return 1;

		return 0;

	}





}






