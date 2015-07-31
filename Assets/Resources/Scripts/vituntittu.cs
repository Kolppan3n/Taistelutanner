using UnityEngine;
using System.Collections;

public class vituntittu : MonoBehaviour {
	
	Renderer Turhaapaskaa;

	void Start () {
		Turhaapaskaa = this.gameObject.GetComponent<Renderer> ();
		Turhaapaskaa.sortingLayerName = "Behind";
		Turhaapaskaa.sortingOrder = 6;
	}
}
