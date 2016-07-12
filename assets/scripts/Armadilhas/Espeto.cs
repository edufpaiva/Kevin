﻿using UnityEngine;
using System.Collections;

public class Espeto : MonoBehaviour {
    public float altura;
    public float lateral;
    private bool jaFoi = false;
    public AudioSource espeto;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {
        if (!jaFoi) {
            if (col.gameObject.tag == "Player")
            {
                espeto.Play();
                transform.position = new Vector3((transform.position.x + lateral), (transform.position.y + altura), transform.position.z);
                //GetComponent<Rigidbody2D>().velocity = Vector2.up * altura;
                
            }

            jaFoi = true;
        }
        


    }
}
