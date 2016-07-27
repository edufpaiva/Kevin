using UnityEngine;
using System.Collections;

public class NumeroDaFase : MonoBehaviour {
    public int numeroDaFase;

    void Awake() {
        GameManager.Instance.SetNumeroDaFase(numeroDaFase);
        
        

    }
    void Start() {
        GameManager.Instance.SetNumeroDaFase(numeroDaFase);
        if (!GameManager.Instance.GetComponent<SceneManager>().IsPlaying(numeroDaFase))
        {
            GameManager.Instance.GetComponent<SceneManager>().SetMusic(numeroDaFase);
        }
    }

}
