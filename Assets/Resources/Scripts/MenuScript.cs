using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public partial class MenuScript : MonoBehaviour {

	GameObject[] Pages;
	Sprite[] Heroes;
	Sprite[] Cards;
	int H = 0;
	int P = 0;

	public void MenuButtons(int Select){

		switch (Select) {

		case 1:
			return;

		case 2:
			return;

		case 3:
			Application.LoadLevel (1);
			return;

		case 4:
			Application.Quit ();
			return;

		case 5:
			Application.LoadLevel (0);
			return;
		}
	}

	public void DeckEditorButtons(int Select){
				
		switch (Select) {
					
		case 1:
			{
				H++;

				if (H == Heroes.Length)
				H = 0;

				GameObject.Find ("Hero").transform.GetComponent<Image> ().sprite = Heroes [H];

				return;
			}
					
		case 2:
		{
			if(P < Pages.Length - 1){
				P++;
				PageTurner(P);
			}
				return;
		}
					
		case 3:
		{
			if(P > 0){
				P--;
				PageTurner(P);
			}
			return;
		}
					
		case 4:
			return;
		}
	}


	void Start(){

		Heroes = Resources.LoadAll<Sprite> ("Images/Heroes/Portrait");
		Cards = Resources.LoadAll<Sprite> ("Images/Cards");
		Pages = GameObject.FindGameObjectsWithTag ("Page").OrderBy (go => go.name).ToArray ();

		for (int k = 1; k < Cards.Length; k++) {
			GameObject.Find("Slot " + k).transform.GetComponent<Image>().sprite = Cards[k];
		}

		PageTurner (0);
	}


	void Update(){

		}
	}
