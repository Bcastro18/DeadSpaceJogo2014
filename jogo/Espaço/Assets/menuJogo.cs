using UnityEngine;
using System.Collections;

public class menuJogo : MonoBehaviour {

	public static bool jogar;

	// Use this for initialization
	void Start () {

		jogar = false;
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	void OnGUI(){

		
		if (jogar == false) {
			Screen.showCursor = true;
			if(GUI.Button (new Rect ((Screen.width / 2 - 140), (Screen.height / 2 + 111), 250, 60), "NOVO JOGO")){
				
				Application.LoadLevel(1);
				jogar = true;

				
			}

			if(GUI.Button(new Rect((Screen.width/2 - 93), (Screen.height/2 + 189),150, 60), "SAIR")){

					Application.Quit();
			}
		}	
	
	}

}
