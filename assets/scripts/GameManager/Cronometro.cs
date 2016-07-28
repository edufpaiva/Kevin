using UnityEngine;
using System.Collections;

public class Cronometro : MonoBehaviour {
    private float segundos;
    private int numeroFase;
	// Use this for initialization
	void Start () {
        try
        {
            numeroFase = GameManager.Instance.GetNumeroDaFase();
        }
        catch (System.Exception)
        {

            throw;
        }
        
        


    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.GetPlayerMorto())
        {


        }
        else if (GameManager.Instance.GetFinalDaFase(numeroFase))
        {
            GameManager.Instance.SetTempoFase(Mathf.Round(segundos));

        }
        else {
            segundos += Time.deltaTime;
            GameManager.Instance.SetTempoTemporario(Mathf.Round(segundos));
        }
        
    }

    public float GetTime()
    {
        return Mathf.Round(this.segundos);

    }
}
