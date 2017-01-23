using UnityEngine;
using System.Collections;

public class scriptFim : MonoBehaviour {

	public static bool tela1;
	public static bool controlaVolta;

	// Use this for initialization
	void Start () {

		tela1 = false;
		controlaVolta = false;


	
	}
	
	// Update is called once per frame
	void Update () {

		if((viloes.contaTempo >= viloes.timer) && controlaVolta == true){
			tela1 = true;
		}

		if (tela1) {

			GUI.Button (new Rect (Screen.width / 2, 150, 200, 100), "Proxima Fase Permitida");

			if(viloes.contaTempo >= (viloes.timer + 5)){
				controlaVolta = false;
				Application.LoadLevel(1);
			}
		
		}

	
	}
}
