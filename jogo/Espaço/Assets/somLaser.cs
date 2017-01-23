using UnityEngine;
using System.Collections;

public class somLaser : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(viloes.aparece == true){

			if(Input.GetMouseButtonDown(0)){

				audio.Play();
			}
		
		}
	
	}
}
