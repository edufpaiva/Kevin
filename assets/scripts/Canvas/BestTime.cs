using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestTime : MonoBehaviour {
    private Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        
	}

    void Update() {

        text.text = "Best Time:   " + PlayerPrefs.GetFloat("Fase" + (GameManager.Instance.GetNumeroDaFase()).ToString()) + "s";

    }

}
