using UnityEngine;
using System.Collections;

public class EspetoCaindo : MonoBehaviour {
    public float velocidadeDeQueda;

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
}
