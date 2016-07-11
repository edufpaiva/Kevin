using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MostradorDeTempo : MonoBehaviour {
    private Text text;
    private float segundos = 0;
    private string temp;
    private bool salvou = false;


	// Use this for initialization
	void Start () {
        
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        if (GameManager.Instance.GetTempoTemporario() < 10f)
        {
            temp = "00" + GameManager.Instance.GetTempoTemporario().ToString();
            text.text = temp;

        }
        else if (GameManager.Instance.GetTempoTemporario() < 100f)
        {
            temp = "0" + GameManager.Instance.GetTempoTemporario().ToString();
            text.text = temp;
        }
        else
        {
            temp = GameManager.Instance.GetTempoTemporario().ToString();
            text.text = temp;
        }


    }

    

}
