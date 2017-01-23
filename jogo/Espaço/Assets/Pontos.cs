using UnityEngine;
using System.Collections;

public class Pontos : MonoBehaviour {


	public GUIStyle customGui;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//GetComponent<GUIText> ().text = "Placar: " + controlePontos.placar.ToString ();
	
	}


	void OnGUI(){
	
		GUI.Label (new Rect (0, 0, 100, 100), "Placar: " + viloes.placar.ToString (), customGui);
		if (viloes.aparece == true) {
			GUI.Label (new Rect (0, 50, 100, 100), "Tempo: " + viloes.contaTempo.ToString("f0"), customGui);			}
	}

}
