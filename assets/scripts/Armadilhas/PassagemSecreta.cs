using UnityEngine;
using System.Collections;

public class PassagemSecreta : MonoBehaviour {
    public GameObject[] bloco;

    private Color invisivel = new Color(1f, 1f, 1f, 0.2f);
    private Color visivel = new Color(1f, 1f, 1f, 1f);
    // Use this for initialization
    void Start () {
        for (int i = 0; i < bloco.Length; i++) {
            bloco[i].GetComponent<SpriteRenderer>().color = visivel;

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
            for (int i = 0; i < bloco.Length; i++)
            {
                bloco[i].GetComponent<SpriteRenderer>().color = visivel;
                
            }


        }
    }

}
