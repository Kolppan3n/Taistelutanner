using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System;
using System.Linq;
public class Sorter : MonoBehaviour {




	DirectoryInfo dir;
	FileInfo[] sharps;

	List<Card> Kortit;

	// Use this for initialization
	void Start () {


		Regex reg = new Regex (".*.cs$");
		dir = new DirectoryInfo ("Z:/Projektit/Taistelutanner/Assets/Resources/Scripts/Cards/Creatures/");
		sharps = dir.GetFiles ();

		Kortit = new List<Card> ();

		foreach (FileInfo i in sharps) {
			if(reg.IsMatch(i.Name)){
			int vittu = 0;

			int.TryParse(i.Name.Length.ToString(),out vittu);
			
			string tmp = i.Name.Substring(0,vittu - 3);

			Kortit.Add (System.Activator.CreateInstance(System.Type.GetType(tmp)) as Card);
			Kortit[Kortit.Count-1].SetStats();
			}

		}
		Kortit.Sort (new sortID());
		foreach (Card i in Kortit) {
			Debug.Log ("Kortti:"+i.Name+", ID:"+i.ID);
		}


		//GameObject.Find ("Card").AddComponent (System.Type.GetType(Kortit[0].Name));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public class sortName : IComparer<Card>{
	public int Compare (Card x, Card y)
	{
		if (x.ID <= y.ID)
			return 1;
		if (x.ID == y.ID)
			return 0;
		if (x.ID > y.ID)
			return -1;
		
		return 0;
	}
}


public class sortID : IComparer<Card>{
	public int Compare (Card x, Card y)
	{


		if (x.ID < y.ID)
			return 1;
		if (x.ID == y.ID)
			return 0;
		if (x.ID > y.ID)
			return -1;

		return 0;
		}
	}
}
