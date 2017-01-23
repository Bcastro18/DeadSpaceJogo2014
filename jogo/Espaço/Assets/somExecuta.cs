using UnityEngine;
using System.Collections;

public class somExecuta : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if(menuJogo.jogar == false){
			audio.Play ();
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
