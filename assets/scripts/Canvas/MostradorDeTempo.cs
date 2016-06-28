using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MostradorDeTempo : MonoBehaviour {
    private Text text;
    private float segundos = 0;
    private string temp;



	// Use this for initialization
	void Start () {
        
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        segundos += Time.deltaTime;

        if (Mathf.Round(segundos) < 10f)
        {
            temp = "00" + Mathf.Round(segundos).ToString();
            text.text = temp;
        }
        else if (Mathf.Round(segundos) < 100f )
        {
            temp = "0" + Mathf.Round(segundos).ToString();
            text.text = temp;
        }
        else  {
            temp = Mathf.Round(segundos).ToString();
            text.text = temp;
        }
    }

    public float GetTime() {
        return this.segundos;

    }

    public void Destruir() {
        Destroy(gameObject);

    }
}
