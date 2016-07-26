using UnityEngine;
using System.Collections;

public class EspetoSobeDesce : MonoBehaviour {

    public Vector3 cima = Vector3.zero, baixo = Vector3.zero;
    public float intervaloSobeDesce = 5, intervaloEntreMovimento = 1.5f;
    private bool up;
    public AudioSource lamina;

    // Use this for initialization
    void Start() {
        Up();
        if (cima == Vector3.zero && baixo == Vector3.zero) {
            baixo = transform.position;
            cima = transform.position;
            cima.y += 0.97f;

        }
    }
    void Update() {
        if (up)
        {
            transform.position = Vector3.Lerp(transform.position, cima, Time.deltaTime * intervaloSobeDesce);
        }
        else {
            transform.position = Vector3.Lerp(transform.position, baixo, Time.deltaTime * intervaloSobeDesce);
        }

        

    }
    void Up() {
        up = !up;
        Invoke("Up", intervaloEntreMovimento);
        if (lamina != null)
        {
            lamina.Play();
        }
        


    }

    
    
}
