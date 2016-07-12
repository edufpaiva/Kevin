using UnityEngine;
using System.Collections;

public class FinalDaFase : MonoBehaviour {
    public int numeroDaFase;
    private bool jogadorEsteveAqui = false;

    // Use this for initialization
    void Awake() {
        GameManager.Instance.SetNumeroDaFase(numeroDaFase);
        GameManager.Instance.SetFinalDaFase(numeroDaFase, false);
    }


 

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Player") {
            if (!jogadorEsteveAqui) {
                
                GameManager.Instance.SetFinalDaFase(numeroDaFase, true);
                

            }

        }



    }



}
