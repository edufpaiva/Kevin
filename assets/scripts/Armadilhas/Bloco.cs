using UnityEngine;
using System.Collections;

public class Bloco : MonoBehaviour {
    private SpriteRenderer bloco;
    public AudioSource somBloco;
    private bool tocouSomBloco = false;
    // Use this for initialization
    void Awake () {
        bloco = GetComponent <SpriteRenderer> ();

    }


    void Start () {
        bloco.color = new Color(1f, 1f, 1f, 0f);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Player") {
            //print("FOI");
            bloco.color = new Color(1f, 1f, 1f, 1f);
            if (!tocouSomBloco)
            {
                somBloco.Play();
                tocouSomBloco = true;
            }
        }


    }

}
