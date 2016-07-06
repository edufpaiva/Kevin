using UnityEngine;
using System.Collections;

public class FinalDaFase : MonoBehaviour {
    public int numeroDaFase;
    private bool jogadorEsteveAqui = false;

	// Use this for initialization
	void Start () {
        GameManager.Instance.SetNumeroDaFase(numeroDaFase);
        GameManager.Instance.SetFinalDaFase(numeroDaFase, false);
	}

    void Update() {
        print(GameManager.Instance.GetFinalDaFase(GameManager.Instance.GetNumeroDaFase()));
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Player") {
            if (!jogadorEsteveAqui) {
                
                GameManager.Instance.SetFinalDaFase(numeroDaFase, true);
                

            }

        }



    }



}
