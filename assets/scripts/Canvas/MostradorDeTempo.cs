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
        print(GameManager.Instance.GetFinalDaFase(GameManager.Instance.GetNumeroDaFase()));
        print(GameManager.Instance.GetNumeroDaFase());
        if (GameManager.Instance.GetPlayerMorto())
        {

        }
        else if (salvou)
        {
            print(segundos + "  foi salvo");

        }
        else if (GameManager.Instance.GetFinalDaFase(GameManager.Instance.GetNumeroDaFase())) {
            
            if (!salvou) {
                GameManager.Instance.SetTempoFase(GameManager.Instance.GetNumeroDaFase(), Mathf.Round(segundos));
                salvou = true;
            }

        } else {
            segundos += Time.deltaTime;

            if (Mathf.Round(segundos) < 10f)
            {
                temp = "00" + Mathf.Round(segundos).ToString();
                text.text = temp;
            }
            else if (Mathf.Round(segundos) < 100f)
            {
                temp = "0" + Mathf.Round(segundos).ToString();
                text.text = temp;
            }
            else
            {
                temp = Mathf.Round(segundos).ToString();
                text.text = temp;
            }
        }

        
    }

    public float GetTime() {
        return Mathf.Round(this.segundos);

    }

}
