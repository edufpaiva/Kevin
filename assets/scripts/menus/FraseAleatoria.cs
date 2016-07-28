using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FraseAleatoria : MonoBehaviour {
    public Sprite[] Frase;
    
	// Use this for initialization
	void Start () {
        Sprite novoSprite = Frase[Random.Range(0, Frase.Length)];
        GetComponent<Image>().sprite = novoSprite;
	}
	
	
}
