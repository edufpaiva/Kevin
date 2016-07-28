using UnityEngine;
using System.Collections;

public class NumeroDaFase : MonoBehaviour {
    public int numeroDaFase;

    void Awake() {
        try
        {
            GameManager.Instance.SetNumeroDaFase(numeroDaFase);
        }
        catch (System.Exception)
        {
            //Awake();
            throw;
        }
        
        
        

    }
    void Start() {
        GameManager.Instance.SetNumeroDaFase(numeroDaFase);
        if (!GameManager.Instance.GetComponent<SceneManager>().IsPlaying(numeroDaFase))
        {
            GameManager.Instance.GetComponent<SceneManager>().SetMusic(numeroDaFase);
        }
    }

}
