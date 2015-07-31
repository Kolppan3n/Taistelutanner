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
		return 0;
	}
}
