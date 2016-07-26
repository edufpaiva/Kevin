using UnityEngine;
using System.Collections;

public class EspetoCaindo : MonoBehaviour {
    public float velocidadeDeQueda;
    public AudioSource hitTheGroundSound;
    private bool hitTheGroundPlayed = false;

    private Rigidbody2D espeto;


	// Use this for initialization
	void Start () {
        espeto = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") {
            espeto.velocity = new Vector3(0, velocidadeDeQueda, 0);

        }

    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Chao")
        {
            if (!hitTheGroundPlayed)
            {
                hitTheGroundSound.Play();
                hitTheGroundPlayed = false;
            }
        }
    }
}
