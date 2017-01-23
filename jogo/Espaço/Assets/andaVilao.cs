using UnityEngine;
using System.Collections;

public class andaVilao : MonoBehaviour {


	public Transform target;
	public float moveSpeed;
	public int rotationSpeed;
	private Transform myTransform;
	public float maxRange;
	public float minRange;

	bool hit;
	public float tempoHit;
	float tempoHitAndando;
	float contTiroAcertos;

	// Use this for initialization
	void Start () {

		tempoHitAndando = tempoHit;
		contTiroAcertos = 0;

		myTransform = transform;
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

		movimento ();

		if (hit){
			Atacando ();
		}
	}

	void movimento()
	{	
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			
			//Look at target
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
			
			if ((Vector3.Distance(transform.position, target.position) < maxRange) && (Vector3.Distance(transform.position, target.position) > minRange))
			{
				transform.LookAt(target);
				transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
			}
	}
	void OnTriggerEnter(Collider col){
	
		if (col.transform.tag == "tiro") {
			contTiroAcertos++;
			if(contTiroAcertos == 3){
				Destroy(gameObject);
				viloes.placar += 1000;
			}

		}

		if(col.transform.tag == "Player"){
			hit = true;
		}
	}

	void Atacando(){
		if ((tempoHitAndando += Time.deltaTime) > tempoHit) {
			if(menuJogo.jogar == true){
				personagem.life += 15;
			}
			tempoHitAndando = 0;
		}
	}
}
