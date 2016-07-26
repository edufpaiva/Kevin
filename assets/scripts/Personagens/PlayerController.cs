using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private bool isDead;
    public AudioSource evilLaugh;
    public GameObject[] menuMorto;
    public GameObject kevinMorto;
    public GameObject kevinGanhador;


    


	// Use this for initialization
	void Start () {
        isDead = false;
        GameManager.Instance.SetPlayerMorto(false);
      
        // teste de audio por proximidade do objeto
        //  GetComponent<AudioListener>().gameObject.SetActive(false);

       // GetComponent<AudioListener>().gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Death") {

            if (!GameManager.Instance.GetPlayerMorto()) {
                GameManager.Instance.SetPlayerMorto(true);
                GameManager.Instance.SetMortes();
                isDead = true;
                GetComponent<Animator>().SetTrigger("Dano");
                GetComponent<Animator>().SetBool("Morrendo", true);
                
                Invoke("TelaMorte", 0.69f);
                Instantiate(kevinMorto, transform.position, Quaternion.identity);
                Destroy(gameObject, 0.7f);

            }


        }

        if (col.gameObject.tag == "FinalDaFase")
        {
            Instantiate(kevinGanhador, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

    public bool GetIsDead() {

        return this.isDead;
    }

    void TelaMorte()
    {

        menuMorto[0].SetActive(false);
        menuMorto[1].SetActive(true);

    }


}
