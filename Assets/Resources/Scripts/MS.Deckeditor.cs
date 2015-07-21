using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public partial class MenuScript : MonoBehaviour {

	void PageTurner(int T){

		foreach (GameObject go in Pages) {
			go.SetActive(false);
		}
		Pages [T].SetActive (true);
		Debug.Log (T);
	}

	public int CompareTo (Card other)
	{
		
		/*if (this.name < other.name)
			return -1;
		if (this.name == other.name)
			return 0;
		if (this.name > other.name)
			return 1;*/
		
		return 0;
	}
}
