using UnityEngine;
using System.Collections;

public class BotoesMovimento : MonoBehaviour {
	private GameObject personagem;
	public int direcao;
	// Use this for initialization
	void Start () {
		personagem = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseStay(){

		personagem.GetComponent<PlayerMovementController> ().SetDirection (direcao);

	}

	void OnMouseUp(){

        personagem.GetComponent<PlayerMovementController>().SetDirection(0);

	}
}
