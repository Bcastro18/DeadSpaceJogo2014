using UnityEngine;
using System.Collections;

public class personagem : MonoBehaviour {

	public Texture textura;
	Vector3 target;
	public float velocidade;
	private float vel;
	bool dash;
	private float tempo;
	public bool playerStay;
	public Transform stay;
    float contaTempo;

	public static int life; // Life 
	public static int maxLife; //Valor maximo de life 


	public GameObject bala;
	public float tempoEntreTiros;
	//public static bool novaCena2; // habilita a partir da vida
	
	// Use this for initialization
	void Start () {
		
		vel = velocidade;
		target = transform.position;
		playerStay = false;
		maxLife = 250;
		life = 0;
        contaTempo = 0;
		//novaCena2 = false;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

				if (viloes.aparece == true) {
						if (playerStay && stay != null) {
								transform.position = new Vector3 (transform.position.x, stay.position.y, transform.position.z);
						}
		
						//Movimento do Player em direção ao mouse
						//target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
						//target.z = transform.position.z;
						//transform.position = Vector3.MoveTowards(transform.position, target, vel * Time.deltaTime);
		
						Vector2 mousePos;
						Vector2 objectPos;
						float playerRotationAngle;

						mousePos = Input.mousePosition;
						objectPos = Camera.main.WorldToScreenPoint (transform.position);
						mousePos.x = mousePos.x - objectPos.x;

						mousePos.y = mousePos.y - objectPos.y;
						playerRotationAngle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		
						transform.rotation = Quaternion.Euler (new Vector3 (0, 0, playerRotationAngle));
						//Fim do movimento do Player em direção ao mouse

						if ((tempoEntreTiros -= Time.deltaTime) < 0) {
								if (Input.GetMouseButtonDown (0)) {
										GameObject aux = Instantiate (bala, transform.position, Quaternion.identity) as GameObject;
										aux.rigidbody.rotation = aux.rigidbody.rotation * Quaternion.Euler (0, 0, transform.rotation.eulerAngles.z);				
								}
						}
				}
		}

	void OnGUI(){

		if ((maxLife - life) > 0) { 
			GUI.DrawTexture (new Rect (Screen.width / 2 - 400, Screen.height / 2 + 300, maxLife - life, 30), textura);//vida
		}

		if ((maxLife - life) <= 0) {
                    
						GUI.Button(new Rect (Screen.width / 2 - 50, Screen.height / 2 + 50, 200, 200), "FIM DE JOGO");
                        contaTempo += Time.deltaTime;

                        if(contaTempo >= 5){
							menuJogo.jogar = false;
						    Application.LoadLevel(0);
						}
		}
	}
}
