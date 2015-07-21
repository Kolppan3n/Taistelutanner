using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public partial class LibraryScript : MonoBehaviour {

	public class Hero{

		public int ID;
		public string Name;
		public string Cardtext;
		public int Attack;
		public int Health;
		public Sprite Image;
	}

	public class Deck{

		public string Name;
		public List<Card> Decklist;
		public Deck(string N, List<Card> DL){
			Name = N;
			Decklist = DL;
		}
	}
}
