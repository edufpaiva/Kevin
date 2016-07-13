using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private bool isDead;
    public AudioSource evilLaugh;
    public GameObject[] menuMorto;


	// Use this for initialization
	void Start () {
        isDead = false;
        GameManager.Instance.SetPlayerMorto(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Death") {
            GameManager.Instance.SetPlayerMorto(true);
            GameManager.Instance.SetMortes();
            isDead = true;
            GetComponent<Animator>().SetBool("Morrendo", true);
            evilLaugh.Play();
            menuMorto[0].SetActive(false);
            menuMorto[1].SetActive(true);
            Destroy(gameObject, 1f);


        }

    }

    public bool GetIsDead() {

        return this.isDead;
    }


}
