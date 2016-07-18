using UnityEngine;
using System.Collections;

public class PassagemSecreta : MonoBehaviour {
    public GameObject[] bloco;

    private Color invisivel = new Color(1f, 1f, 1f, 0.2f);
    public float timer = 0.05f;
    private float opacidade;
    private bool visivel = false;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < bloco.Length; i++) {
            bloco[i].GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);

        }
	}

    void Update() {
        if (visivel && timer == 0)
        {
            Destroy(gameObject);
        }else if (visivel & opacidade < 1)
        {

            for (int i = 0; i < bloco.Length; i++)
            {
                bloco[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, opacidade);

            }
            opacidade += timer;
        }
        else if (visivel && opacidade > 1)
        {
            opacidade = 1;
            visivel = false;
            for (int i = 0; i < bloco.Length; i++)
            {
                bloco[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, opacidade);

            }
            opacidade = 0;

        }
        else {

        }


    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") {
            for (int i = 0; i < bloco.Length; i++)
            {
                bloco[i].GetComponent<SpriteRenderer>().color = invisivel;

            }


        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            visivel = true;


        }
    }

}
