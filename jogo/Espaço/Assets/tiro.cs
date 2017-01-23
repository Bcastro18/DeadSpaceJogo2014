using UnityEngine;
using System.Collections;

public class tiro : MonoBehaviour {

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody.AddForce (transform.right * 100);
	
	}
}
