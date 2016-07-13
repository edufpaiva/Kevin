using UnityEngine;
using System.Collections;

public class FinalDaFase : MonoBehaviour {
    private int numeroDaFase;
    private bool jogadorEsteveAqui = false;

    
    public GameObject[] mCanvas;

    // Use this for initialization
    void Awake() {
        
        
    }
    void Start() {
        numeroDaFase = GameManager.Instance.GetNumeroDaFase();
        GameManager.Instance.SetFinalDaFase(numeroDaFase, false);

    }


 

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Player") {
            if (!jogadorEsteveAqui && !GameManager.Instance.GetPlayerMorto()) {
                
                GameManager.Instance.SetFinalDaFase(numeroDaFase, true);
                mCanvas[0].SetActive(false);
                mCanvas[1].SetActive(true);


            }

        }



    }



}
