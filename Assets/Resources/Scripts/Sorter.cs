using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Sorter : MonoBehaviour {


	List<Card> kortit;

	// Use this for initialization
	void Start () {
		kortit = new List<Card> ();

		kortit.Add (new Accumulate ());
		kortit.Add (new Journeys_End ());
		kortit.Add (new Grow ());
		kortit.Add (new Damatican_Battlepriest ());
		kortit.Add (new Damatican_Footman ());

		foreach (Card i in kortit) {
			i.SetStats ();
			Debug.Log (i.Name + i.ID);
		}

		kortit.Sort (new cardcompareID());

		foreach (Card i in kortit)
			Debug.Log (i.Name + i.ID);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


public class cardcompareID : IComparer<Card>{
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
