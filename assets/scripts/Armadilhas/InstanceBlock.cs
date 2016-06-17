using UnityEngine;
using System.Collections;

public class InstanceBlock : MonoBehaviour {
	public GameObject objeto;
    public float tempo = 0.5f;
    private SpriteRenderer bloco;


    // Use this for initialization
    void Awake()
    {
        bloco = GetComponent<SpriteRenderer>();

    }


    void Start()
    {
        bloco.color = new Color(1f, 1f, 1f, 0f);

    }

    // Update is called once per frame
    void Update () {
	
	}

	void OnTriggerExit2D(Collider2D col){
        Invoke("InstanciaObjeto", tempo);

	}
    void InstanciaObjeto() {
        Instantiate(objeto, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }


}
