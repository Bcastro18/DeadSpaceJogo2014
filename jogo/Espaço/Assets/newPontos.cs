using UnityEngine;
using System.Collections;

public class newPontos : MonoBehaviour {

	public GUIStyle inicial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnGUI(){
		if (menuJogo.jogar == false) {
			GUI.Label (new Rect (Screen.width / 2 , 0 , 100, 100), "Recorde de pontos: " + viloes.placar.ToString (), inicial);
		}	
	
	}
}
