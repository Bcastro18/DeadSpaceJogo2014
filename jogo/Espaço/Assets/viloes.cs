using UnityEngine;
using System.Collections;

public class viloes : MonoBehaviour {

	public Transform [] Spawnviloes;
	public GameObject vilao;
	public static float timer;
	public static bool aparece;
	float contador;
	public static float placar;
	public static float contaTempo;
	public static bool novaTela;//habilita nova tela a partir do tempo
	public static bool controlaViloes;
	public static float tempo;
	// Use this for initialization
	void Start () {

		timer =  0;
		aparece = false;
		contador = 17;
		contaTempo = 0;
		novaTela = false;
		controlaViloes = false;
		tempo = 30;
	}
	
	// Update is called once per frame
	void Update () {
		contador += Time.deltaTime;
		timer -= Time.deltaTime;

		if (aparece == true) {
			contaTempo += Time.deltaTime;
		}
		if (timer > 0) {
			if(contador > 16){
				if(controlaViloes == true){
					ApareceVilao();
					contador = 0;
				}
			}
		}
	}
	void OnGUI(){

		if(aparece == false){
			if(GUI.Button (new Rect (Screen.width / 2, 150, 100, 100), "30 segundos")){
				timer=30;
				tempo = 30;
				aparece = true;
				controlaViloes = true;
			}
			if(GUI.Button (new Rect (Screen.width / 2, 250, 100, 100), "60 segundos")){
				timer=60;
				tempo = 60;
				aparece = true;
				controlaViloes = true;

			}
			if(GUI.Button (new Rect (Screen.width / 2, 350, 100, 100), "120 segundos")){
				timer=120;
				tempo=120;
				aparece = true;
				controlaViloes = true;
			}
		}

		if (contaTempo >= tempo && (personagem.maxLife - personagem.life)>0) {
			novaTela = true;
		}
		if (novaTela == true) {
			controlaViloes = false;
			if(GUI.Button (new Rect (Screen.width / 2, 150, 200, 100), "Proxima Fase Permitida")){
				Application.LoadLevel(2);
				scriptFim.controlaVolta = true;
				
			}
		}
	}
	void ApareceVilao(){
		if(Random.Range(0,101) < 100){
			for (int i = 0; i < Spawnviloes.Length; i++) {
				GameObject viloesClone = (GameObject) Instantiate(vilao, Spawnviloes[i].position, Quaternion.identity);
				viloesClone.transform.eulerAngles = new Vector3(-90, 180,0);
			}
		}
	}

}

