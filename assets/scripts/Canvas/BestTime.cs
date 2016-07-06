using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestTime : MonoBehaviour {
    private Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = "Best Time:   " + GameManager.Instance.GetTempoFase(GameManager.Instance.GetNumeroDaFase()) + "s"; 
	}

}
