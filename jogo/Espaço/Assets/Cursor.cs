using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {


	public Texture2D cursor;
	public Texture2D normal;
	public Texture2D link;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (menuJogo.jogar == false) {
				Screen.showCursor = true;
				cursor = link;		
		} else {
				Screen.showCursor = false;
				cursor = normal;
		}

	
	}

	void OnGUI(){

		GUI.Label(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y - 10, 100, 100), cursor);
	
	
	}
}
