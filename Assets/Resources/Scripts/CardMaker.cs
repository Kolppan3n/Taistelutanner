using UnityEngine;
using System.Collections;

public class CardMaker : MonoBehaviour {

	public GameObject Card;
	private Color[] CTColor;
	public string testeri;


	public void Manameikker (GameObject tmp){
		int bawlz;
		bawlz = tmp.GetComponent<Card> ().Cost.Length - 1;

		tmp.transform.Find ("Mana").GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Images/Cards/Manasymbols/" + tmp.GetComponent<Card> ().Faction);

		if (bawlz > 1) {
		}
	}

	public void Synnytys(float X, float Y, string WhereTo, string Kortti){

		Vector3 Pos = new Vector3 (X, Y, 1);

		if (WhereTo == "Library") {

			/*string skipper;
			string subskip;*/

			GameObject tmp = Instantiate (Card, Pos, transform.rotation) as GameObject;

			tmp.AddComponent(System.Type.GetType(Kortti));
			tmp.GetComponent<Card>().SetStats();

			tmp.transform.Find("TextBG").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Cards/Overlay/" + tmp.GetComponent<Card>().Faction);
			tmp.transform.Find("Rarity").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Cards/Overlay/" + tmp.GetComponent<Card>().Rarity); 
			tmp.transform.Find("Art").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Cards/Art/" + tmp.GetComponent<Card>().Image); 

			tmp.transform.Find("Type").GetComponent<TextMesh>().text = tmp.GetComponent<Card>().Type;
			tmp.transform.Find("Name").GetComponent<TextMesh>().text = tmp.GetComponent<Card>().Name;
			tmp.transform.Find("Cardtext").GetComponent<TextMesh>().text = tmp.GetComponent<Card>().Cardtext;
			/*skipper = tmp.GetComponent<Card>().Cardtext;

			subskip = skipper.Substring*/


			if (tmp.GetComponent<Card>().Faction == "Chaos")
				tmp.transform.Find("Cardtext").GetComponent<TextMesh>().color = CTColor[1];
			else
				tmp.transform.Find("Cardtext").GetComponent<TextMesh>().color = CTColor[0];
			//Card.transform.parent = GameObject.Find ("Canvas").transform;
		}



	}

	// Use this for initialization
	void Start () {
		CTColor = new Color[2]{Color.black, Color.white};
		Card = Resources.Load<GameObject> ("Prefabs/Card");

		Synnytys (0, 0, "Library", testeri);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
