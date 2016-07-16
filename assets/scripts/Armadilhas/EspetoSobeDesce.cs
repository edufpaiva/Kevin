using UnityEngine;
using System.Collections;

public class EspetoSobeDesce : MonoBehaviour {
    public float velocidade;
    private Vector3 startPosition;
    public float x, y;
    public float intervalo;

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        Invoke("Up", intervalo);
	}
	
	// Update is called once per frame
	void Up () {
        transform.Translate(new Vector2(x,y) * velocidade * Time.deltaTime);
        Invoke("Down", 0.5f);
    }

    void Down () {
        transform.Translate(new Vector2(-x, -y) * velocidade * Time.deltaTime);
        Invoke("Up", intervalo);
    }
    
}
